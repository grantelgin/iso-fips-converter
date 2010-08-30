using System;
using System.Text;

public static class ISO2ToFIPSConvertor
{
    private static string defaultResult = "--";

    public static string GetFipsCode(string Iso2Code)
    {
        if(Iso2Code == null)
        {
            return defaultResult;
        }
        if (Iso2Code.Length != 2)
        {
            return defaultResult;
        }

        Iso2Code = Iso2Code.ToUpper();
        byte[] asciiBytes = Encoding.ASCII.GetBytes(Iso2Code);


        switch(asciiBytes[0])
        {
            case 65:
                {
                    switch(asciiBytes[1])
                    {
                        case 68: return "AN";    //AD
                        case 69: return "AE";    //AE
                        case 70: return "AF";    //AF
                        case 71: return "AC";    //AG
                        case 73: return "AV";    //AI
                        case 76: return "AL";    //AL
                        case 77: return "AM";    //AM
                        case 78: return "NT";    //AN
                        case 79: return "AO";    //AO
                        case 81: return "AY";    //AQ
                        case 82: return "AR";    //AR
                        case 83: return "AQ";    //AS
                        case 84: return "AU";    //AT
                        case 85: return "AS";    //AU
                        case 87: return "AA";    //AW
                        case 90: return "AJ";    //AZ
                        default: return defaultResult;
                    }
                }
                case 66:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "BK";    //BA
                        case 66: return "BB";    //BB
                        case 68: return "BG";    //BD
                        case 69: return "BE";    //BE
                        case 70: return "UV";    //BF
                        case 71: return "BU";    //BG
                        case 72: return "BA";    //BH
                        case 73: return "BY";    //BI
                        case 74: return "BN";    //BJ
                        case 77: return "BD";    //BM
                        case 78: return "BX";    //BN
                        case 79: return "BL";    //BO
                        case 82: return "BR";    //BR
                        case 83: return "BF";    //BS
                        case 84: return "BT";    //BT
                        case 87: return "BC";    //BW
                        case 89: return "BO";    //BY
                        case 90: return "BH";    //BZ
                        default: return defaultResult;
                    }
                }
                case 67:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "CA";    //CA
                        case 67: return "CK";    //CC
                        case 68: return "CG";    //CD
                        case 70: return "CT";    //CF
                        case 71: return "CF";    //CG
                        case 72: return "SZ";    //CH
                        case 73: return "IV";    //CI
                        case 75: return "CW";    //CK
                        case 76: return "CI";    //CL
                        case 77: return "CM";    //CM
                        case 78: return "CH";    //CN
                        case 79: return "CO";    //CO
                        case 82: return "CS";    //CR
                        case 85: return "CU";    //CU
                        case 86: return "CV";    //CV
                        case 88: return "KT";    //CX
                        case 89: return "CY";    //CY
                        case 90: return "EZ";    //CZ
                        default: return defaultResult;
                    }
                }
                case 68:
                {
                    switch (asciiBytes[1])
                    {
                        case 69: return "GM";    //DE
                        case 74: return "DJ";    //DJ
                        case 75: return "DA";    //DK
                        case 77: return "DO";    //DM
                        case 79: return "DR";    //DO
                        case 90: return "AG";    //DZ
                        default: return defaultResult;
                    }
                }
                case 69:
                {
                    switch (asciiBytes[1])
                    {
                        case 67: return "EC";    //EC
                        case 69: return "EN";    //EE
                        case 71: return "EG";    //EG
                        case 72: return "WI";    //EH
                        case 82: return "ER";    //ER
                        case 83: return "SP";    //ES
                        case 84: return "ET";    //ET
                        default: return defaultResult;
                    }
                }
                case 70:
                {
                    switch (asciiBytes[1])
                    {
                        case 73: return "FI";    //FI
                        case 74: return "FJ";    //FJ
                        case 75: return "FK";    //FK
                        case 77: return "FM";    //FM
                        case 79: return "FO";    //FO
                        case 82: return "FR";    //FR
                        default: return defaultResult;
                    }
                }
                case 71:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "GB";    //GA
                        case 66: return "UK";    //GB
                        case 68: return "GJ";    //GD
                        case 69: return "GG";    //GE
                        case 70: return "FG";    //GF
                        case 72: return "GH";    //GH
                        case 73: return "GI";    //GI
                        case 76: return "GL";    //GL
                        case 77: return "GA";    //GM
                        case 78: return "GV";    //GN
                        case 80: return "GP";    //GP
                        case 81: return "EK";    //GQ
                        case 82: return "GR";    //GR
                        case 83: return "SX";    //GS
                        case 84: return "GT";    //GT
                        case 85: return "GQ";    //GU
                        case 87: return "PU";    //GW
                        case 89: return "GY";    //GY
                        default: return defaultResult;
                    }
                }
                case 72:
                {
                    switch (asciiBytes[1])
                    {
                        case 75: return "HK";    //HK
                        case 78: return "HO";    //HN
                        case 82: return "HR";    //HR
                        case 84: return "HA";    //HT
                        case 85: return "HU";    //HU
                        default: return defaultResult;
                    }
                }
                case 73:
                {
                    switch (asciiBytes[1])
                    {
                        case 68: return "ID";    //ID
                        case 69: return "EI";    //IE
                        case 76: return "IS";    //IL
                        case 78: return "IN";    //IN
                        case 81: return "IZ";    //IQ
                        case 82: return "IR";    //IR
                        case 83: return "IC";    //IS
                        case 84: return "IT";    //IT
                        default: return defaultResult;
                    }
                }
                case 74:
                {
                    switch (asciiBytes[1])
                    {
                        case 77: return "JM";    //JM
                        case 79: return "JO";    //JO
                        case 80: return "JA";    //JP
                        default: return defaultResult;
                    }
                }
                case 75:
                {
                    switch (asciiBytes[1])
                    {
                        case 69: return "KE";    //KE
                        case 71: return "KG";    //KG
                        case 72: return "CB";    //KH
                        case 73: return "KR";    //KI
                        case 77: return "CN";    //KM
                        case 78: return "SC";    //KN
                        case 80: return "KN";    //KP
                        case 82: return "KS";    //KR
                        case 87: return "KU";    //KW
                        case 89: return "CJ";    //KY
                        case 90: return "KZ";    //KZ
                        default: return defaultResult;
                    }
                }
                case 76:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "LA";    //LA
                        case 66: return "LE";    //LB
                        case 67: return "ST";    //LC
                        case 73: return "LS";    //LI
                        case 75: return "CE";    //LK
                        case 82: return "LI";    //LR
                        case 83: return "LT";    //LS
                        case 84: return "LH";    //LT
                        case 85: return "LU";    //LU
                        case 86: return "LG";    //LV
                        case 89: return "LY";    //LY
                        default: return defaultResult;
                    }
                }
                case 77:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "MO";    //MA
                        case 67: return "MN";    //MC
                        case 68: return "MD";    //MD
                        case 69: return "MW";    //ME
                        case 71: return "MA";    //MG
                        case 72: return "RM";    //MH
                        case 75: return "MK";    //MK
                        case 76: return "ML";    //ML
                        case 77: return "BM";    //MM
                        case 78: return "MG";    //MN
                        case 79: return "MC";    //MO
                        case 80: return "CQ";    //MP
                        case 81: return "MB";    //MQ
                        case 82: return "MR";    //MR
                        case 83: return "MJ";    //MS
                        case 84: return "MT";    //MT
                        case 85: return "MP";    //MU
                        case 86: return "MV";    //MV
                        case 87: return "MI";    //MW
                        case 88: return "MX";    //MX
                        case 89: return "MY";    //MY
                        case 90: return "MZ";    //MZ
                        default: return defaultResult;
                    }
                }
                case 78:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "WA";    //NA
                        case 67: return "NC";    //NC
                        case 69: return "NG";    //NE
                        case 70: return "NF";    //NF
                        case 71: return "NI";    //NG
                        case 73: return "NU";    //NI
                        case 76: return "NL";    //NL
                        case 79: return "NO";    //NO
                        case 80: return "NP";    //NP
                        case 82: return "NR";    //NR
                        case 85: return "NE";    //NU
                        case 90: return "NZ";    //NZ
                        default: return defaultResult;
                    }
                }
                case 79:
                {
                    switch (asciiBytes[1])
                    {
                        case 77: return "MU";    //OM
                        default: return defaultResult;
                    }
                }
                case 80:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "PM";    //PA
                        case 69: return "PE";    //PE
                        case 70: return "FP";    //PF
                        case 71: return "PP";    //PG
                        case 72: return "RP";    //PH
                        case 75: return "PK";    //PK
                        case 76: return "PL";    //PL
                        case 77: return "SB";    //PM
                        case 78: return "PC";    //PN
                        case 82: return "RQ";    //PR
                        case 83: return "gz";//+, we    //PS
                        case 84: return "PO";    //PT
                        case 87: return "PS";    //PW
                        case 89: return "PA";    //PY
                        default: return defaultResult;
                    }
                }
                case 81:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "QA";    //QA
                        default: return defaultResult;
                    }
                }
                case 82:
                {
                    switch (asciiBytes[1])
                    {
                        case 69: return "RE";    //RE
                        case 79: return "RO";    //RO
                        case 83: return "RI";    //RS
                        case 85: return "RS";    //RU
                        case 87: return "RW";    //RW
                        default: return defaultResult;
                    }
                }
                case 83:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "SA";    //SA
                        case 66: return "BP";    //SB
                        case 67: return "SE";    //SC
                        case 68: return "SU";    //SD
                        case 69: return "SW";    //SE
                        case 71: return "SN";    //SG
                        case 72: return "SH";    //SH
                        case 73: return "SI";    //SI
                        case 74: return "SV";    //SJ
                        case 75: return "LO";    //SK
                        case 76: return "SL";    //SL
                        case 77: return "SM";    //SM
                        case 78: return "SG";    //SN
                        case 79: return "SO";    //SO
                        case 82: return "NS";    //SR
                        case 84: return "TP";    //ST
                        case 86: return "ES";    //SV
                        case 89: return "SY";    //SY
                        case 90: return "WZ";    //SZ
                        default: return defaultResult;
                    }
                }
                case 84:
                {
                    switch (asciiBytes[1])
                    {
                        case 67: return "TK";    //TC
                        case 68: return "CD";    //TD
                        case 70: return "FS";    //TF
                        case 71: return "TO";    //TG
                        case 72: return "TH";    //TH
                        case 74: return "TI";    //TJ
                        case 75: return "TL";    //TK
                        case 76: return "TT";    //TL
                        case 77: return "TX";    //TM
                        case 78: return "TS";    //TN
                        case 79: return "TN";    //TO
                        case 82: return "TU";    //TR
                        case 84: return "TD";    //TT
                        case 86: return "TV";    //TV
                        case 87: return "TW";    //TW
                        case 90: return "TZ";    //TZ
                        default: return defaultResult;
                    }
                }
                case 85:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "UP";    //UA
                        case 71: return "UG";    //UG
                        case 83: return "US";    //US
                        case 89: return "UY";    //UY
                        case 90: return "UZ";    //UZ
                        default: return defaultResult;
                    }
                }
                case 86:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "VT";    //VA
                        case 67: return "VC";    //VC
                        case 69: return "VE";    //VE
                        case 71: return "VI";    //VG
                        case 73: return "VG";    //VI
                        //case 73: return "VQ";    //VI - US VIRGIN ISLANDS and UK Virgin Islands has the same ISO code
                        case 78: return "VM";    //VN
                        case 85: return "NH";    //VU
                        default: return defaultResult;
                    }
                }
                case 87:
                {
                    switch (asciiBytes[1])
                    {
                        case 70: return "WF";    //WF
                        case 83: return "WS";    //WS
                        default: return defaultResult;
                    }
                }
                case 89:
                {
                    switch (asciiBytes[1])
                    {
                        case 69: return "YM";    //YE
                        case 84: return "MF";    //YT
                        default: return defaultResult;
                    }
                }
                case 90:
                {
                    switch (asciiBytes[1])
                    {
                        case 65: return "SF";    //ZA
                        case 77: return "ZA";    //ZM
                        case 87: return "ZI";    //ZW
                        default: return defaultResult;
                    }
                }
                default: return defaultResult;
        }
    }
}

