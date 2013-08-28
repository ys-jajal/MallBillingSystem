char uart_rd;
sbit buz at PORTC.B1;
sbit sw at PINC.B0;
unsigned char err[10] = "TimeOut";
unsigned char count;
unsigned char outstring[80];

unsigned char abc = 0;

void init_eeprom()
{
     count = EEPROM_Read(0x100); Delay_ms(10);          // save count on 0x100
}

void writezero()
{
     EEPROM_Write(0x100,0x00);
}



void savebarcode(unsigned char *bar, unsigned int cnt)
{
     unsigned char i;

         for(i=0; i<7; i++)
         {
                  EEPROM_Write(cnt+i,bar[i]);
         }

}
void readbarcode()
{
     unsigned char i,j,bar[7];
     unsigned char kl;
     kl = count*7;

     
     for(j = 0 ; j < kl; j ++)
     {
           
           outstring[j] = EEPROM_Read(j);
           uart1_write(outstring[j]);

     }
   //  outstring[i+1] = '\0';
}
void clearall()
{
     eeprom_write(0x100,0);
}

unsigned char barcode[12], *readcode;
      unsigned char b;
      unsigned char i;
      volatile int flag=0;

void flush()
{
     int j;
     for(j=0;j<20;j++)
     barcode[j] = 0;
}
void main() 
{
      DDRC.B0 = 0; PORTC.B0 = 1;
      DDRC.B1 = 1; PORTC1_bit = 0;
      
      UART1_Init(9600);               // Initialize UART module at 9600 bps
      Delay_ms(1000);                  // Wait for UART module to stabilize
      UART1_Write_Text("Init");   Delay_ms(2000);
      asm sei
      RXCIE_bit = 1;
  //    writezero();
      init_eeprom();
      
      uart1_write(count);

      while (1)
      {
            if(sw == 0)
            {
                  init_eeprom();
                  Delay_ms(1000);
                  asm cli;
                  if(sw == 1)
                  {

                    UART1_Write_Text("READING");
                    readbarcode();
                    Delay_ms(500);
                  //  UART1_Write_Text(outstring); Delay_ms(100);

                  }
                  else
                  {
                      UART1_Write_Text("Clearing");
                      writezero();   count = 0;buz = 1; Delay_ms(2000); buz = 0;
                  }
                  RXEN_bit = 0; Delay_ms(200);RXEN_bit = 1;
                  asm sei;
            }

      }
}
void uart_rxc() iv IVT_ADDR_USART__RXC ics ICS_AUTO 
{
      unsigned int temp;
      barcode[abc] = uart1_read();     //timeout

      abc++;

      if(abc == 7)
      {
        if(strcmp(barcode,err) == 0)
        {
                 UART1_Write_Text(barcode);
                 buz = 1;
                 Delay_ms(1000);
                 buz = 0;
                 abc = 0;
        }
      }
      
      if(abc == 8)
      {
        if(strcmp(barcode,err) != 0)
        {
              init_eeprom();
              buz = 1;
              UART1_Write_Text(barcode);
              temp = count*7;
              savebarcode(barcode,temp);

              abc = 0;
              count++;
              eeprom_write(0x100,count); Delay_ms(2000);
        }
        flush();
        abc = 0;  buz = 0;
        RXEN_bit = 0; RXEN_bit = 1;
      }

}