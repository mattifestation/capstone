﻿// Capstone C# bindings
// By Matt Graeber <@mattifestation>, 2013>

using System;

namespace Capstone.Arm64
{
    public enum SFT
    {
        INVALID = 0,
        LSL,
        MSL,
        LSR,
        ASR,
        ROR
    }

    public enum EXT
    {
        INVALID = 0,
        UXTB,
        UXTH,
        UXTW,
        UXTX,
        SXTB,
        SXTH,
        SXTW,
        SXTX
    }

    public enum CC
    {
        INVALID = 0,
        EQ,    // Equal
        NE,    // Not equal:                 Not equal, or unordered
        HS,    // Unsigned higher or same:   >, ==, or unordered
        LO,    // Unsigned lower or same:    Less than
        MI,    // Minus, negative:           Less than
        PL,    // Plus, positive or zero:    >, ==, or unordered
        VS,    // Overflow:                  Unordered
        VC,    // No overflow:               Ordered
        HI,    // Unsigned higher:           Greater than, or unordered
        LS,    // Unsigned lower or same:    Less than or equal
        GE,    // Greater than or equal:     Greater than or equal
        LT,    // Less than:                 Less than, or unordered
        GT,    // Signed greater than:       Greater than
        LE,    // Signed less than or equal: <, ==, or unordered
        AL,    // Always (unconditional):    Always (unconditional)
        NV     // Always (unconditional):   Always (unconditional)
    }

    public enum OP
    {
        INVALID = 0,   // Uninitialized.
        REG,   // Register operand.
        CIMM,  // C-Immediate
        IMM,	// Immediate operand.
        FP,	// Floating-Point immediate operand.
        MEM	// Memory operand
    }

    public enum REG
    {
        INVALID = 0,
        NZCV,
        WSP,
        SP,
        B0,
        B1,
        B2,
        B3,
        B4,
        B5,
        B6,
        B7,
        B8,
        B9,
        B10,
        B11,
        B12,
        B13,
        B14,
        B15,
        B16,
        B17,
        B18,
        B19,
        B20,
        B21,
        B22,
        B23,
        B24,
        B25,
        B26,
        B27,
        B28,
        B29,
        B30,
        B31,
        D0,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        D10,
        D11,
        D12,
        D13,
        D14,
        D15,
        D16,
        D17,
        D18,
        D19,
        D20,
        D21,
        D22,
        D23,
        D24,
        D25,
        D26,
        D27,
        D28,
        D29,
        D30,
        D31,
        H0,
        H1,
        H2,
        H3,
        H4,
        H5,
        H6,
        H7,
        H8,
        H9,
        H10,
        H11,
        H12,
        H13,
        H14,
        H15,
        H16,
        H17,
        H18,
        H19,
        H20,
        H21,
        H22,
        H23,
        H24,
        H25,
        H26,
        H27,
        H28,
        H29,
        H30,
        H31,
        Q0,
        Q1,
        Q2,
        Q3,
        Q4,
        Q5,
        Q6,
        Q7,
        Q8,
        Q9,
        Q10,
        Q11,
        Q12,
        Q13,
        Q14,
        Q15,
        Q16,
        Q17,
        Q18,
        Q19,
        Q20,
        Q21,
        Q22,
        Q23,
        Q24,
        Q25,
        Q26,
        Q27,
        Q28,
        Q29,
        Q30,
        Q31,
        S0,
        S1,
        S2,
        S3,
        S4,
        S5,
        S6,
        S7,
        S8,
        S9,
        S10,
        S11,
        S12,
        S13,
        S14,
        S15,
        S16,
        S17,
        S18,
        S19,
        S20,
        S21,
        S22,
        S23,
        S24,
        S25,
        S26,
        S27,
        S28,
        S29,
        S30,
        S31,
        W0,
        W1,
        W2,
        W3,
        W4,
        W5,
        W6,
        W7,
        W8,
        W9,
        W10,
        W11,
        W12,
        W13,
        W14,
        W15,
        W16,
        W17,
        W18,
        W19,
        W20,
        W21,
        W22,
        W23,
        W24,
        W25,
        W26,
        W27,
        W28,
        W29,
        W30,
        X0,
        X1,
        X2,
        X3,
        X4,
        X5,
        X6,
        X7,
        X8,
        X9,
        X10,
        X11,
        X12,
        X13,
        X14,
        X15,
        X16,
        X17,
        X18,
        X19,
        X20,
        X21,
        X22,
        X23,
        X24,
        X25,
        X26,
        X27,
        X28,
        X29,
        X30,

        MAX,		// <-- mark the end of the list of registers

        //> alias registers

        IP1 = X16,
        IP0 = X17,
        FP = X29,
        LR = X30,
        //XZR = SP,
        //WZR = WSP
    }

    public enum INSN
    {
        INVALID = 0,

        ABS,
        ADC,
        ADDHN2,
        ADDHN,
        ADDP,
        ADDV,
        ADD,
        CMN,
        ADRP,
        ADR,
        AESD,
        AESE,
        AESIMC,
        AESMC,
        AND,
        ASR,
        AT,
        BFI,
        BFM,
        BFXIL,
        BIC,
        BIF,
        BIT,
        BLR,
        BL,
        BRK,
        BR,
        BSL,
        B,
        CBNZ,
        CBZ,
        CCMN,
        CCMP,
        CLREX,
        CLS,
        CLZ,
        CMEQ,
        CMGE,
        CMGT,
        CMHI,
        CMHS,
        CMLE,
        CMLT,
        CMP,
        CMTST,
        CNT,
        CRC32B,
        CRC32CB,
        CRC32CH,
        CRC32CW,
        CRC32CX,
        CRC32H,
        CRC32W,
        CRC32X,
        CSEL,
        CSINC,
        CSINV,
        CSNEG,
        DCPS1,
        DCPS2,
        DCPS3,
        DC,
        DMB,
        DRPS,
        DSB,
        DUP,
        EON,
        EOR,
        ERET,
        EXTR,
        EXT,
        FABD,
        FABS,
        FACGE,
        FACGT,
        FADDP,
        FADD,
        FCCMPE,
        FCCMP,
        FCMEQ,
        FCMGE,
        FCMGT,
        FCMLE,
        FCMLT,
        FCMP,
        FCMPE,
        FCSEL,
        FCVTAS,
        FCVTAU,
        FCVTL,
        FCVTL2,
        FCVTMS,
        FCVTMU,
        FCVTN,
        FCVTN2,
        FCVTNS,
        FCVTNU,
        FCVTPS,
        FCVTPU,
        FCVTXN,
        FCVTXN2,
        FCVTZS,
        FCVTZU,
        FCVT,
        FDIV,
        FMADD,
        FMAXNMP,
        FMAXNMV,
        FMAXNM,
        FMAXP,
        FMAXV,
        FMAX,
        FMINNMP,
        FMINNMV,
        FMINNM,
        FMINP,
        FMINV,
        FMIN,
        FMLA,
        FMLS,
        FMOV,
        FMSUB,
        FMULX,
        FMUL,
        FNEG,
        FNMADD,
        FNMSUB,
        FNMUL,
        FRECPE,
        FRECPS,
        FRECPX,
        FRINTA,
        FRINTI,
        FRINTM,
        FRINTN,
        FRINTP,
        FRINTX,
        FRINTZ,
        FRSQRTE,
        FRSQRTS,
        FSQRT,
        FSUB,
        HINT,
        HLT,
        HVC,
        IC,
        INS,
        ISB,
        LD1,
        LD1R,
        LD2,
        LD2R,
        LD3,
        LD3R,
        LD4,
        LD4R,
        LDARB,
        LDAR,
        LDARH,
        LDAXP,
        LDAXRB,
        LDAXR,
        LDAXRH,
        LDPSW,
        LDRSB,
        LDURSB,
        LDRSH,
        LDURSH,
        LDRSW,
        LDR,
        LDTRSB,
        LDTRSH,
        LDTRSW,
        LDURSW,
        LDXP,
        LDXRB,
        LDXR,
        LDXRH,
        LDRH,
        LDURH,
        STRH,
        STURH,
        LDTRH,
        STTRH,
        LDUR,
        STR,
        STUR,
        LDTR,
        STTR,
        LDRB,
        LDURB,
        STRB,
        STURB,
        LDTRB,
        STTRB,
        LDP,
        LDNP,
        STNP,
        STP,
        LSL,
        LSR,
        MADD,
        MLA,
        MLS,
        MOVI,
        MOVK,
        MOVN,
        MOVZ,
        MRS,
        MSR,
        MSUB,
        MUL,
        MVNI,
        MVN,
        NEG,
        NOT,
        ORN,
        ORR,
        PMULL2,
        PMULL,
        PMUL,
        PRFM,
        PRFUM,
        SQRSHRUN2,
        SQRSHRUN,
        SQSHRUN2,
        SQSHRUN,
        RADDHN2,
        RADDHN,
        RBIT,
        RET,
        REV16,
        REV32,
        REV64,
        REV,
        ROR,
        RSHRN2,
        RSHRN,
        RSUBHN2,
        RSUBHN,
        SABAL2,
        SABAL,
        SABA,
        SABDL2,
        SABDL,
        SABD,
        SADALP,
        SADDL2,
        SADDLP,
        SADDLV,
        SADDL,
        SADDW2,
        SADDW,
        SBC,
        SBFIZ,
        SBFM,
        SBFX,
        SCVTF,
        SDIV,
        SHA1C,
        SHA1H,
        SHA1M,
        SHA1P,
        SHA1SU0,
        SHA1SU1,
        SHA256H,
        SHA256H2,
        SHA256SU0,
        SHA256SU1,
        SHADD,
        SHLL2,
        SHLL,
        SHL,
        SHRN2,
        SHRN,
        SHSUB,
        SLI,
        SMADDL,
        SMAXP,
        SMAXV,
        SMAX,
        SMC,
        SMINP,
        SMINV,
        SMIN,
        SMLAL2,
        SMLAL,
        SMLSL2,
        SMLSL,
        SMOV,
        SMSUBL,
        SMULH,
        SMULL2,
        SMULL,
        SQABS,
        SQADD,
        SQDMLAL2,
        SQDMLAL,
        SQDMLSL2,
        SQDMLSL,
        SQDMULH,
        SQDMULL2,
        SQDMULL,
        SQNEG,
        SQRDMULH,
        SQRSHL,
        SQRSHRN,
        SQRSHRN2,
        SQSHLU,
        SQSHL,
        SQSHRN,
        SQSHRN2,
        SQSUB,
        SQXTN,
        SQXTN2,
        SQXTUN,
        SQXTUN2,
        SRHADD,
        SRI,
        SRSHL,
        SRSHR,
        SRSRA,
        SSHLL2,
        SSHLL,
        SSHL,
        SSHR,
        SSRA,
        SSUBL2,
        SSUBL,
        SSUBW2,
        SSUBW,
        ST1,
        ST2,
        ST3,
        ST4,
        STLRB,
        STLR,
        STLRH,
        STLXP,
        STLXRB,
        STLXR,
        STLXRH,
        STXP,
        STXRB,
        STXR,
        STXRH,
        SUBHN2,
        SUBHN,
        SUB,
        SUQADD,
        SVC,
        SXTB,
        SXTH,
        SXTW,
        SYSL,
        SYS,
        TBL,
        TBNZ,
        TBX,
        TBZ,
        TLBI,
        TRN1,
        TRN2,
        TST,
        UABAL2,
        UABAL,
        UABA,
        UABDL2,
        UABDL,
        UABD,
        UADALP,
        UADDL2,
        UADDLP,
        UADDLV,
        UADDL,
        UADDW2,
        UADDW,
        UBFIZ,
        UBFM,
        UBFX,
        UCVTF,
        UDIV,
        UHADD,
        UHSUB,
        UMADDL,
        UMAXP,
        UMAXV,
        UMAX,
        UMINP,
        UMINV,
        UMIN,
        UMLAL2,
        UMLAL,
        UMLSL2,
        UMLSL,
        UMOV,
        UMSUBL,
        UMULH,
        UMULL2,
        UMULL,
        UQADD,
        UQRSHL,
        UQRSHRN,
        UQRSHRN2,
        UQSHL,
        UQSHRN,
        UQSHRN2,
        UQSUB,
        UQXTN,
        UQXTN2,
        URECPE,
        URHADD,
        URSHL,
        URSHR,
        URSQRTE,
        URSRA,
        USHLL2,
        USHLL,
        USHL,
        USHR,
        USQADD,
        USRA,
        USUBL2,
        USUBL,
        USUBW2,
        USUBW,
        UXTB,
        UXTH,
        UZP1,
        UZP2,
        XTN,
        XTN2,
        ZIP1,
        ZIP2,

        // alias insn
        MNEG,
        UMNEGL,
        SMNEGL,
        MOV,
        NOP,
        YIELD,
        WFE,
        WFI,
        SEV,
        SEVL,
        NGC,

        MAX  // <-- mark the end of the list of insn
    }

    public enum GRP
    {
        INVALID = 0,

        CRYPTO,
        FPARMV8,
        NEON,
        JUMP,	// all jump instructions (conditional+direct+indirect jumps)

        MAX   // <-- mark the end of the list of groups
    }
}