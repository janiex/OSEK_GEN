#if(SELECTED_MICROCONTROLLER == _MSP430_x54x_) 
	#include <msp430x54x.h>
#elif(SELECTED_MICROCONTROLLER == _MSP430_xG46x_)
	#include <msp430xG46x.h>
#else 
	#error "Inplausible selection of MSP430 derivate"
#endif //(SELECTED_MICROCONTROLLER == _MSP430_x54x_) AND (SELECTED_MICROCONTROLLER == _MSP430_xG46x_)
#include "OS_cfg.h"
#if(SELECTED_MICROCONTROLLER == _MSP430_x54x_)

static unsigned char PutChar(unsigned char p);	
void SendString(unsigned char *pcString);
unsigned char GetChar();

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/
static unsigned char PutChar(unsigned char p)
 {

  while (!(UCA3IFG&UCTXIFG));             // USCI_A0 TX buffer ready?
  UCA3TXBUF = p;     // UCTXIFG is set when UCAxTXBUF empty
  return 0;
 }
	
void SendString(unsigned char *pcString)
{
unsigned char *pxNext;
pxNext = ( unsigned char * ) pcString;
	while( *pxNext )
	{
		(void)PutChar( *pxNext);
		pxNext++;
	}
}

unsigned char GetChar() {
    if (UCA3IFG & UCRXIFG)
      return UCA3RXBUF;
    else
      return 0;
}

#pragma vector=USCI_A3_VECTOR
__interrupt void USCI_A3_ISR(void)
{
    switch(__even_in_range(UCA3IV,4))
  {
    case 0: break;                          // Vector 0 - no interrupt
    case 2:                                 // Vector 2 - RXIFG
		rx_char = UCA3RXBUF;
		PutChar(rx_char);
      break;
    case 4:break;                             // Vector 4 - TXIFG
    default: break;
  }
}

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/

void UART3_Init(unsigned int baud)
{
//    float n, x;
    P10DIR |= BIT4;      //set P10.4=1 (Transmitter) as output
    P10DIR &= ~BIT5;  //set P10.5=0 (Receiver) as input
    P10SEL |= BIT4 + BIT5; //set P10.4=1 & P10.5=1 as TX/RX



  // After a PUC, the UCSWRST bit is automatically set,
  //  keeping the USCI in a reset condition
    UCA3CTL1 |= UCSWRST; //UCSWRST = 1 (bit0 = 1), USCI_A3 Software Reset

  //select SMCLK as BaudRate source clock UCA3CTL1( bit7 = 1, bit6 = 0 )
    UCA3CTL1 = (UCA3CTL1 | BIT7) & ~BIT6;

  //calculate registers for the BaudRate +
    UCA3MCTL &=~(BIT0); //No oversampling mode enabled  bit0 => UCOS16 = 0
    //calculate UCBR
    UCA3BR0 = 78;
    UCA3BR1 = 0;
    UCA3MCTL |= UCBRS_2;
    UCA3CTL0 = 0x00;      //Set Format Frame: 8 bit data; no parity; 1 stop bit

    UCA3CTL1 &= ~UCSWRST; //UCSWRST = 0 (bit0 = 0), released for operation.
	UCA3IE |= UCRXIE;                // Enable USCI_A3 RX interrupt
}

/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/

void InitHW(void)
{
 WDTCTL = WDTPW + WDTHOLD;                 // Stop watchdog timer
 P4DIR = 0xFF;
 P4OUT = 0x00;
 P10DIR |= BIT6+BIT7;
 P10OUT &= ~(BIT6+BIT7);
 P11DIR |= BIT1+BIT2;  // P11.1-2 to output direction
 P11SEL |= BIT1+BIT2;  // P11.1-2 output for MCLK and SMCLK, EXT1-9,8
 P5SEL  |= BIT2 + BIT3;  // P5.2 & P5.3 as XT2IN/XT2OUT
 
 P1DIR |= BIT0;  // P1.0 to output direction
 P1SEL |= BIT0;  // P1.0 to output ACLK, EXT2-5
 P7SEL |= BIT0 + BIT1; // Port select XT1CLK
 
 UCSCTL6 &= ~XT2OFF;         // set XT2OFF=0 (bit8 = 0) --> enable XT2
 UCSCTL3 |= SELREF__XT1CLK; // FLL reference select, 000b = XT1CLK
        // Since LFXT1 is not used,
        // sourcing FLL with LFXT1 can cause
        // XT1OFFG flag to set
 UCSCTL4 |= SELA__XT1CLK; // ACLK=LFXT1,   SMCLK=DCO,MCLK=DCO

 // Loop until XT1,XT2 & DCO stabilizes
 do
 {
  UCSCTL7 &= ~(XT2OFFG + XT1LFOFFG + XT1HFOFFG + DCOFFG);
  /* Clear XT2,XT1,DCO fault flags                                          */
  SFRIFG1 &= ~OFIFG;  // Clear fault flags
 }while (SFRIFG1&OFIFG);  /* Test oscillator fault flag                     */
 /* XT2 oscillator operating range is 16 MHz to 24 MHz.                     */
 /* XT1 oscillator operating range is 4 MHz to 8 MHz.                       */
 UCSCTL6 |= XT2DRIVE_2 + XT1DRIVE_0;  
 /* SMCLK Source Divider f(XT2)/2 , MCLK=XT1/1                              */
 UCSCTL5 |= DIVM__1 + DIVS__2;  
 /* MCLK Source Divider f(XT2)- SMCLK=XT2/2; MCLK=XT2; ACLK=XT1              */
 UCSCTL4 |= SELS__XT2CLK + SELM__XT2CLK + SELA__XT1CLK; 
 /*UART3 INITIALIZATION                                                      */
 UART3_Init(115200);
 /* System time tick configuration                                           */
 TA1CTL   |= TASSEL_1 + MC_1 + TACLR; /* ACLK, UP_mode,, clear TAR           */
 /* input freq for Timer A is 32768 Hz                                       */
 TA1CCR0   = COUNTS_PER_TICK;/* count with value 33 for 1ms                  */
 TA1CCTL0 |= CCIE;             /* CCR0 interrupt enabled                     */
}
#elif(SELECTED_MICROCONTROLLER == _MSP430_xG46x_)

	#define _8MHZ 	1
	#define _32KHZ	2
	#define CLOCK _8MHZ
	#if (CLOCK == _32KHZ)
/*******************************************************************************
**                                                                            **
** FUNC-NAME     :                                                            **
**                                                                            **
** DESCRIPTION   :                                                            **
**                                                                            **
** PRECONDITIONS :                                                            **
**                                                                            **
** PARAMETER     :                                                            **
**                                                                            **
** RETURN        :                                                            **
**                                                                            **
** REMARKS       :                                                            **
**                                                                            **
*******************************************************************************/

	void InitHW(void)
	{
		volatile unsigned int i;
		WDTCTL = WDTPW +WDTHOLD;                  // Stop WDT
		FLL_CTL0 |= XCAP14PF;                     // Configure load caps
	  // Wait for xtal to stabilize
		do
		  {
		  IFG1 &= ~OFIFG;                           // Clear OSCFault flag
		  for (i = 0x47FF; i > 0; i--);             // Time for flag to set
		  }
		  while ((IFG1 & OFIFG));

		  P2SEL = BIT4|BIT5;                        // P2.4,5 = USCI_A0 RXD/TXD

		  UCA0CTL1 |= UCSSEL_2;                     // SMCLK
		  UCA0BR0 = 0x09;                           // 1MHz 115200
		  UCA0BR1 = 0x00;                           // 1MHz 115200
		  UCA0MCTL = 0x02;                          // Modulation
		  UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
									  // P5.1 output
		  TACCTL0 = CCIE;                           // TACCR0 interrupt enabled
		  TACCR0 = 5000;
		  TACTL = TASSEL_2 + MC_2;                  // SMCLK, continuous mode

	}
	#elif (CLOCK == _8MHZ)
	void InitHW(void){
		volatile unsigned int i;

	  WDTCTL = WDTPW+WDTHOLD;                   // Stop WDT
	  FLL_CTL0 |= XCAP14PF;                     // Configure load caps
	  FLL_CTL1 &= ~XT2OFF;                      // Clear bit = HFXT2 on

	  // Wait for xtal to stabilize
	  do
	  {
	  IFG1 &= ~OFIFG;                           // Clear OSCFault flag
	  for (i = 0x47FF; i > 0; i--);             // Time for flag to set
	  }
	  while ((IFG1 & OFIFG));                   // OSCFault flag still set?
	  FLL_CTL1 |= SELM_XT2;                     // MCLK = XT2

	  BTCTL = BT_ADLY_16;                     	// 16-miliseconds interrupt
	  IE2 |= BTIE;                              // Enable Basic Timer interrupt

	  //P5DIR |= 0x002;                           // P5.1 = output direction
	  P2SEL = BIT4|BIT5;                        // P2.4,5 = USCI_A0 RXD/TXD

	  UCA0CTL1 |= UCSSEL_2;                     // SMCLK
	  UCA0BR0 = 0x09;                           // 1MHz 115200
	  UCA0BR1 = 0x00;                           // 1MHz 115200
	  UCA0MCTL = 0x02;                          // Modulation
	  UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
	  
	  P5DIR |= 0x02;                           // P5.1 = output direction
	  P2DIR |= 0x06;
	  P5OUT &= ~(0x02);
	  P2OUT &= ~(0x06);
	}

	#else
		#error Wrong Configuration of the Clock
	#endif

#else
	#error Inplausible MSP430 derivate selection!
#endif // (SELECTED_MICROCONTROLLER == _MSP430_x54x_) AND (SELECTED_MICROCONTROLLER == _MSP430_xG46x_)

