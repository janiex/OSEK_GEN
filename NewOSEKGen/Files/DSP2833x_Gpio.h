// TI File $Revision: /main/4 $
// Checkin $Date: November 15, 2007   09:58:53 $
//###########################################################################
//
// FILE:   DSP2833x_Gpio.h
//
// TITLE:  DSP2833x General Purpose I/O Definitions.
//
//###########################################################################
// $TI Release: DSP2833x/DSP2823x C/C++ Header Files V1.31 $
// $Release Date: August 4, 2009 $
//###########################################################################

#ifndef DSP2833x_GPIO_H
#define DSP2833x_GPIO_H


#ifdef __cplusplus
extern "C" {
#endif

//----------------------------------------------------
// GPIO A control register bit definitions */
struct GPACTRL_BITS {        // bits   description
   uint16 QUALPRD0:8;        // 7:0    Qual period
   uint16 QUALPRD1:8;        // 15:8   Qual period
   uint16 QUALPRD2:8;        // 23:16  Qual period
   uint16 QUALPRD3:8;        // 31:24  Qual period
};

union GPACTRL_REG {
   uint32              all;
   struct GPACTRL_BITS bit;
};

//----------------------------------------------------
// GPIO B control register bit definitions */
struct GPBCTRL_BITS {        // bits   description
   uint16 QUALPRD0:8;        // 7:0    Qual period
   uint16 QUALPRD1:8;        // 15:8   Qual period
   uint16 QUALPRD2:8;        // 23:16  Qual period
   uint16 QUALPRD3:8;        // 31:24
};

union GPBCTRL_REG {
   uint32              all;
   struct GPBCTRL_BITS bit;
};

//----------------------------------------------------
// GPIO A Qual/MUX select register bit definitions */
struct GPA1_BITS {            // bits   description
   uint16 GPIO0:2;            // 1:0    GPIO0
   uint16 GPIO1:2;            // 3:2    GPIO1
   uint16 GPIO2:2;            // 5:4    GPIO2
   uint16 GPIO3:2;            // 7:6    GPIO3
   uint16 GPIO4:2;            // 9:8    GPIO4
   uint16 GPIO5:2;            // 11:10  GPIO5
   uint16 GPIO6:2;            // 13:12  GPIO6
   uint16 GPIO7:2;            // 15:14  GPIO7
   uint16 GPIO8:2;            // 17:16  GPIO8
   uint16 GPIO9:2;            // 19:18  GPIO9
   uint16 GPIO10:2;           // 21:20  GPIO10
   uint16 GPIO11:2;           // 23:22  GPIO11
   uint16 GPIO12:2;           // 25:24  GPIO12
   uint16 GPIO13:2;           // 27:26  GPIO13
   uint16 GPIO14:2;           // 29:28  GPIO14
   uint16 GPIO15:2;           // 31:30  GPIO15
};


struct GPA2_BITS {            // bits   description
   uint16 GPIO16:2;           // 1:0    GPIO16
   uint16 GPIO17:2;           // 3:2    GPIO17
   uint16 GPIO18:2;           // 5:4    GPIO18
   uint16 GPIO19:2;           // 7:6    GPIO19
   uint16 GPIO20:2;           // 9:8    GPIO20
   uint16 GPIO21:2;           // 11:10  GPIO21
   uint16 GPIO22:2;           // 13:12  GPIO22
   uint16 GPIO23:2;           // 15:14  GPIO23
   uint16 GPIO24:2;           // 17:16  GPIO24
   uint16 GPIO25:2;           // 19:18  GPIO25
   uint16 GPIO26:2;           // 21:20  GPIO26
   uint16 GPIO27:2;           // 23:22  GPIO27
   uint16 GPIO28:2;           // 25:24  GPIO28
   uint16 GPIO29:2;           // 27:26  GPIO29
   uint16 GPIO30:2;           // 29:28  GPIO30
   uint16 GPIO31:2;           // 31:30  GPIO31
};

struct GPB1_BITS {            // bits   description
   uint16 GPIO32:2;           // 1:0    GPIO32
   uint16 GPIO33:2;           // 3:2    GPIO33
   uint16 GPIO34:2;           // 5:4    GPIO34
   uint16 GPIO35:2;           // 7:6    GPIO35
   uint16 GPIO36:2;           // 9:8    GPIO36
   uint16 GPIO37:2;           // 11:10  GPIO37
   uint16 GPIO38:2;           // 13:12  GPIO38
   uint16 GPIO39:2;           // 15:14  GPIO39
   uint16 GPIO40:2;           // 17:16  GPIO40
   uint16 GPIO41:2;           // 19:16  GPIO41
   uint16 GPIO42:2;           // 21:20  GPIO42
   uint16 GPIO43:2;           // 23:22  GPIO43
   uint16 GPIO44:2;           // 25:24  GPIO44
   uint16 GPIO45:2;           // 27:26  GPIO45
   uint16 GPIO46:2;           // 29:28  GPIO46
   uint16 GPIO47:2;           // 31:30  GPIO47
};

struct GPB2_BITS  {           // bits   description
   uint16 GPIO48:2;           // 1:0    GPIO48
   uint16 GPIO49:2;           // 3:2    GPIO49
   uint16 GPIO50:2;           // 5:4    GPIO50
   uint16 GPIO51:2;           // 7:6    GPIO51
   uint16 GPIO52:2;           // 9:8    GPIO52
   uint16 GPIO53:2;           // 11:10  GPIO53
   uint16 GPIO54:2;           // 13:12  GPIO54
   uint16 GPIO55:2;           // 15:14  GPIO55
   uint16 GPIO56:2;           // 17:16  GPIO56
   uint16 GPIO57:2;           // 19:18  GPIO57
   uint16 GPIO58:2;           // 21:20  GPIO58
   uint16 GPIO59:2;           // 23:22  GPIO59
   uint16 GPIO60:2;           // 25:24  GPIO60
   uint16 GPIO61:2;           // 27:26  GPIO61
   uint16 GPIO62:2;           // 29:28  GPIO62
   uint16 GPIO63:2;           // 31:30  GPIO63
};

struct GPC1_BITS {            // bits   description
   uint16 GPIO64:2;           // 1:0    GPIO64
   uint16 GPIO65:2;           // 3:2    GPIO65
   uint16 GPIO66:2;           // 5:4    GPIO66
   uint16 GPIO67:2;           // 7:6    GPIO67
   uint16 GPIO68:2;           // 9:8    GPIO68
   uint16 GPIO69:2;           // 11:10  GPIO69
   uint16 GPIO70:2;           // 13:12  GPIO70
   uint16 GPIO71:2;           // 15:14  GPIO71
   uint16 GPIO72:2;           // 17:16  GPIO72
   uint16 GPIO73:2;           // 19:18  GPIO73
   uint16 GPIO74:2;           // 21:20  GPIO74
   uint16 GPIO75:2;           // 23:22  GPIO75
   uint16 GPIO76:2;           // 25:24  GPIO76
   uint16 GPIO77:2;           // 27:26  GPIO77
   uint16 GPIO78:2;           // 29:28  GPIO78
   uint16 GPIO79:2;           // 31:30  GPIO79
};


struct GPC2_BITS {            // bits   description
   uint16 GPIO80:2;           // 1:0    GPIO80
   uint16 GPIO81:2;           // 3:2    GPIO81
   uint16 GPIO82:2;           // 5:4    GPIO82
   uint16 GPIO83:2;           // 7:6    GPIO83
   uint16 GPIO84:2;           // 9:8    GPIO84
   uint16 GPIO85:2;           // 11:10  GPIO85
   uint16 GPIO86:2;           // 13:12  GPIO86
   uint16 GPIO87:2;           // 15:14  GPIO87
   uint16 rsvd:16;            // 31:16  reserved
};


union GPA1_REG {
   uint32              all;
   struct GPA1_BITS    bit;
};

union GPA2_REG {
   uint32              all;
   struct GPA2_BITS    bit;
};

union GPB1_REG {
   uint32              all;
   struct GPB1_BITS    bit;
};

union GPB2_REG {
   uint32              all;
   struct GPB2_BITS    bit;
};

union GPC1_REG {
   uint32              all;
   struct GPC1_BITS    bit;
};

union GPC2_REG {
   uint32              all;
   struct GPC2_BITS    bit;
};

//----------------------------------------------------
// GPIO A DIR/TOGGLE/SET/CLEAR register bit definitions */
struct GPADAT_BITS {          // bits   description
   uint16 GPIO0:1;            // 0      GPIO0
   uint16 GPIO1:1;            // 1      GPIO1
   uint16 GPIO2:1;            // 2      GPIO2
   uint16 GPIO3:1;            // 3      GPIO3
   uint16 GPIO4:1;            // 4      GPIO4
   uint16 GPIO5:1;            // 5      GPIO5
   uint16 GPIO6:1;            // 6      GPIO6
   uint16 GPIO7:1;            // 7      GPIO7
   uint16 GPIO8:1;            // 8      GPIO8
   uint16 GPIO9:1;            // 9      GPIO9
   uint16 GPIO10:1;           // 10     GPIO10
   uint16 GPIO11:1;           // 11     GPIO11
   uint16 GPIO12:1;           // 12     GPIO12
   uint16 GPIO13:1;           // 13     GPIO13
   uint16 GPIO14:1;           // 14     GPIO14
   uint16 GPIO15:1;           // 15     GPIO15
   uint16 GPIO16:1;           // 16     GPIO16
   uint16 GPIO17:1;           // 17     GPIO17
   uint16 GPIO18:1;           // 18     GPIO18
   uint16 GPIO19:1;           // 19     GPIO19
   uint16 GPIO20:1;           // 20     GPIO20
   uint16 GPIO21:1;           // 21     GPIO21
   uint16 GPIO22:1;           // 22     GPIO22
   uint16 GPIO23:1;           // 23     GPIO23
   uint16 GPIO24:1;           // 24     GPIO24
   uint16 GPIO25:1;           // 25     GPIO25
   uint16 GPIO26:1;           // 26     GPIO26
   uint16 GPIO27:1;           // 27     GPIO27
   uint16 GPIO28:1;           // 28     GPIO28
   uint16 GPIO29:1;           // 29     GPIO29
   uint16 GPIO30:1;           // 30     GPIO30
   uint16 GPIO31:1;           // 31     GPIO31
};

struct GPBDAT_BITS {          // bits   description
   uint16 GPIO32:1;           // 0      GPIO32
   uint16 GPIO33:1;           // 1      GPIO33
   uint16 GPIO34:1;           // 2      GPIO34
   uint16 GPIO35:1;           // 3      GPIO35
   uint16 GPIO36:1;           // 4      GPIO36
   uint16 GPIO37:1;           // 5      GPIO37
   uint16 GPIO38:1;           // 6      GPIO38
   uint16 GPIO39:1;           // 7      GPIO39
   uint16 GPIO40:1;           // 8      GPIO40
   uint16 GPIO41:1;           // 9      GPIO41
   uint16 GPIO42:1;           // 10     GPIO42
   uint16 GPIO43:1;           // 11     GPIO43
   uint16 GPIO44:1;           // 12     GPIO44
   uint16 GPIO45:1;           // 13     GPIO45
   uint16 GPIO46:1;           // 14     GPIO46
   uint16 GPIO47:1;           // 15     GPIO47
   uint16 GPIO48:1;           // 16     GPIO48
   uint16 GPIO49:1;           // 17     GPIO49
   uint16 GPIO50:1;           // 18     GPIO50
   uint16 GPIO51:1;           // 19     GPIO51
   uint16 GPIO52:1;           // 20     GPIO52
   uint16 GPIO53:1;           // 21     GPIO53
   uint16 GPIO54:1;           // 22     GPIO54
   uint16 GPIO55:1;           // 23     GPIO55
   uint16 GPIO56:1;           // 24     GPIO56
   uint16 GPIO57:1;           // 25     GPIO57
   uint16 GPIO58:1;           // 26     GPIO58
   uint16 GPIO59:1;           // 27     GPIO59
   uint16 GPIO60:1;           // 28     GPIO60
   uint16 GPIO61:1;           // 29     GPIO61
   uint16 GPIO62:1;           // 30     GPIO62
   uint16 GPIO63:1;           // 31     GPIO63
};

struct GPCDAT_BITS {          // bits   description
   uint16 GPIO64:1;           // 0      GPIO64
   uint16 GPIO65:1;           // 1      GPIO65
   uint16 GPIO66:1;           // 2      GPIO66
   uint16 GPIO67:1;           // 3      GPIO67
   uint16 GPIO68:1;           // 4      GPIO68
   uint16 GPIO69:1;           // 5      GPIO69
   uint16 GPIO70:1;           // 6      GPIO70
   uint16 GPIO71:1;           // 7      GPIO71
   uint16 GPIO72:1;           // 8      GPIO72
   uint16 GPIO73:1;           // 9      GPIO73
   uint16 GPIO74:1;           // 10     GPIO74
   uint16 GPIO75:1;           // 11     GPIO75
   uint16 GPIO76:1;           // 12     GPIO76
   uint16 GPIO77:1;           // 13     GPIO77
   uint16 GPIO78:1;           // 14     GPIO78
   uint16 GPIO79:1;           // 15     GPIO79
   uint16 GPIO80:1;           // 16     GPIO80
   uint16 GPIO81:1;           // 17     GPIO81
   uint16 GPIO82:1;           // 18     GPIO82
   uint16 GPIO83:1;           // 19     GPIO83
   uint16 GPIO84:1;           // 20     GPIO84
   uint16 GPIO85:1;           // 21     GPIO85
   uint16 GPIO86:1;           // 22     GPIO86
   uint16 GPIO87:1;           // 23     GPIO87
   uint16 rsvd1:8;            // 31:24  reserved
};


union GPADAT_REG {
   uint32              all;
   struct GPADAT_BITS  bit;
};

union GPBDAT_REG {
   uint32              all;
   struct GPBDAT_BITS  bit;
};

union GPCDAT_REG {
   uint32              all;
   struct GPCDAT_BITS  bit;
};




//----------------------------------------------------
// GPIO Xint1/XINT2/XNMI select register bit definitions */
struct GPIOXINT_BITS {        // bits   description
    uint16 GPIOSEL:5;         // 4:0    Select GPIO interrupt input source
    uint16 rsvd1:11;          // 15:5   reserved
};

union GPIOXINT_REG {
   uint16                all;
   struct GPIOXINT_BITS  bit;
};


struct GPIO_CTRL_REGS {
   union  GPACTRL_REG  GPACTRL;   // GPIO A Control Register (GPIO0 to 31)
   union  GPA1_REG     GPAQSEL1;  // GPIO A Qualifier Select 1 Register (GPIO0 to 15)
   union  GPA2_REG     GPAQSEL2;  // GPIO A Qualifier Select 2 Register (GPIO16 to 31)
   union  GPA1_REG     GPAMUX1;   // GPIO A Mux 1 Register (GPIO0 to 15)
   union  GPA2_REG     GPAMUX2;   // GPIO A Mux 2 Register (GPIO16 to 31)
   union  GPADAT_REG   GPADIR;    // GPIO A Direction Register (GPIO0 to 31)
   union  GPADAT_REG   GPAPUD;    // GPIO A Pull Up Disable Register (GPIO0 to 31)
   uint32              rsvd1;
   union  GPBCTRL_REG  GPBCTRL;   // GPIO B Control Register (GPIO32 to 63)
   union  GPB1_REG     GPBQSEL1;  // GPIO B Qualifier Select 1 Register (GPIO32 to 47)
   union  GPB2_REG     GPBQSEL2;  // GPIO B Qualifier Select 2 Register (GPIO48 to 63)
   union  GPB1_REG     GPBMUX1;   // GPIO B Mux 1 Register (GPIO32 to 47)
   union  GPB2_REG     GPBMUX2;   // GPIO B Mux 2 Register (GPIO48 to 63)
   union  GPBDAT_REG   GPBDIR;    // GPIO B Direction Register (GPIO32 to 63)
   union  GPBDAT_REG   GPBPUD;    // GPIO B Pull Up Disable Register (GPIO32 to 63)
   uint16              rsvd2[8];
   union  GPC1_REG     GPCMUX1;   // GPIO C Mux 1 Register (GPIO64 to 79)
   union  GPC2_REG     GPCMUX2;   // GPIO C Mux 2 Register (GPIO80 to 95)
   union  GPCDAT_REG   GPCDIR;    // GPIO C Direction Register (GPIO64 to 95)
   union  GPCDAT_REG   GPCPUD;    // GPIO C Pull Up Disable Register (GPIO64 to 95)
};

struct GPIO_DATA_REGS {
   union  GPADAT_REG       GPADAT;       // GPIO Data Register (GPIO0 to 31)
   union  GPADAT_REG       GPASET;       // GPIO Data Set Register (GPIO0 to 31)
   union  GPADAT_REG       GPACLEAR;     // GPIO Data Clear Register (GPIO0 to 31)
   union  GPADAT_REG       GPATOGGLE;    // GPIO Data Toggle Register (GPIO0 to 31)
   union  GPBDAT_REG       GPBDAT;       // GPIO Data Register (GPIO32 to 63)
   union  GPBDAT_REG       GPBSET;       // GPIO Data Set Register (GPIO32 to 63)
   union  GPBDAT_REG       GPBCLEAR;     // GPIO Data Clear Register (GPIO32 to 63)
   union  GPBDAT_REG       GPBTOGGLE;    // GPIO Data Toggle Register (GPIO32 to 63)
   union  GPCDAT_REG       GPCDAT;       // GPIO Data Register (GPIO64 to 95)
   union  GPCDAT_REG       GPCSET;       // GPIO Data Set Register (GPIO64 to 95)
   union  GPCDAT_REG       GPCCLEAR;     // GPIO Data Clear Register (GPIO64 to 95)
   union  GPCDAT_REG       GPCTOGGLE;    // GPIO Data Toggle Register (GPIO64 to 95)
   uint16                  rsvd1[8];
};

struct GPIO_INT_REGS {
   union  GPIOXINT_REG     GPIOXINT1SEL; // XINT1 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXINT2SEL; // XINT2 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXNMISEL;  // XNMI_Xint13 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXINT3SEL; // XINT3 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXINT4SEL; // XINT4 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXINT5SEL; // XINT5 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXINT6SEL; // XINT6 GPIO Input Selection
   union  GPIOXINT_REG     GPIOXINT7SEL; // XINT7 GPIO Input Selection
   union  GPADAT_REG       GPIOLPMSEL;   // Low power modes GP I/O input select
};


//---------------------------------------------------------------------------
// GPI/O External References & Function Declarations:
//
extern volatile struct GPIO_CTRL_REGS GpioCtrlRegs;
extern volatile struct GPIO_DATA_REGS GpioDataRegs;
extern volatile struct GPIO_INT_REGS GpioIntRegs;

#ifdef __cplusplus
}
#endif /* extern "C" */

#endif  // end of DSP2833x_GPIO_H definition

//===========================================================================
// End of file.
//===========================================================================
