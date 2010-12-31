using System;
using System.Text;

namespace ISOFIPSConvertor
{

    public static class FIPSToISO2Convertor
    {
        private static string defaultResult = "--";

        public static string GetISO2Code(string FIPSCode)
        {
            if (FIPSCode == null)
            {
                return defaultResult;
            }
            if (FIPSCode.Length != 2)
            {
                return defaultResult;
            }

            FIPSCode = FIPSCode.ToUpper();

            byte[] asciiBytes = Encoding.ASCII.GetBytes(FIPSCode);


            switch (asciiBytes[0])
            {

                case 65:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "AW";    //
                            case 67: return "AG";    //
                            case 69: return "AE";    //
                            case 70: return "AF";    //
                            case 71: return "DZ";    //
                            case 74: return "AZ";    //
                            case 76: return "AL";    //
                            case 77: return "AM";    //
                            case 78: return "AD";    //
                            case 79: return "AO";    //
                            case 81: return "AS";    //
                            case 82: return "AR";    //
                            case 83: return "AU";    //
                            case 85: return "AT";    //
                            case 86: return "AI";    //
                            case 89: return "AQ";    //
                            default: return defaultResult;
                        }
                    }
                case 66:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "BH";    //
                            case 66: return "BB";    //
                            case 67: return "BW";    //
                            case 68: return "BM";    //
                            case 69: return "BE";    //
                            case 70: return "BS";    //
                            case 71: return "BD";    //
                            case 72: return "BZ";    //
                            case 75: return "BA";    //
                            case 76: return "BO";    //
                            case 77: return "MM";    //
                            case 78: return "BJ";    //
                            case 79: return "BY";    //
                            case 80: return "SB";    //
                            case 82: return "BR";    //
                            case 84: return "BT";    //
                            case 85: return "BG";    //
                            case 88: return "BN";    //
                            case 89: return "BI";    //
                            default: return defaultResult;
                        }
                    }
                case 67:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "CA";    //
                            case 66: return "KH";    //
                            case 68: return "TD";    //
                            case 69: return "LK";    //
                            case 70: return "CG";    //
                            case 71: return "CD";    //
                            case 72: return "CN";    //
                            case 73: return "CL";    //
                            case 74: return "KY";    //
                            case 75: return "CC";    //
                            case 77: return "CM";    //
                            case 78: return "KM";    //
                            case 79: return "CO";    //
                            case 81: return "MP";    //
                            case 83: return "CR";    //
                            case 84: return "CF";    //
                            case 85: return "CU";    //
                            case 86: return "CV";    //
                            case 87: return "CK";    //
                            case 89: return "CY";    //
                            default: return defaultResult;
                        }
                    }
                case 68:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "DK";    //
                            case 74: return "DJ";    //
                            case 79: return "DM";    //
                            case 82: return "DO";    //
                            default: return defaultResult;
                        }
                    }
                case 69:
                    {
                        switch (asciiBytes[1])
                        {
                            case 67: return "EC";    //
                            case 71: return "EG";    //
                            case 73: return "IE";    //
                            case 75: return "GQ";    //
                            case 78: return "EE";    //
                            case 82: return "ER";    //
                            case 83: return "SV";    //
                            case 84: return "ET";    //
                            case 90: return "CZ";    //
                            default: return defaultResult;
                        }
                    }
                case 70:
                    {
                        switch (asciiBytes[1])
                        {
                            case 71: return "GF";    //
                            case 73: return "FI";    //
                            case 74: return "FJ";    //
                            case 75: return "FK";    //
                            case 77: return "FM";    //
                            case 79: return "FO";    //
                            case 80: return "PF";    //
                            case 82: return "FR";    //
                            case 83: return "TF";    //
                            default: return defaultResult;
                        }
                    }
                case 71:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "GM";    //
                            case 66: return "GA";    //
                            case 71: return "GE";    //
                            case 72: return "GH";    //
                            case 73: return "GI";    //
                            case 74: return "GD";    //
                            case 76: return "GL";    //
                            case 77: return "DE";    //
                            case 80: return "GP";    //
                            case 81: return "GU";    //
                            case 82: return "GR";    //
                            case 84: return "GT";    //
                            case 86: return "GN";    //
                            case 89: return "GY";    //
                            case 90: return "PS";    // GZ - Gaza, also see WE - West Bank
                            default: return defaultResult;
                        }
                    }
                case 72:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "HT";    //
                            case 75: return "HK";    //
                            case 79: return "HN";    //
                            case 82: return "HR";    //
                            case 85: return "HU";    //
                            default: return defaultResult;
                        }
                    }
                case 73:
                    {
                        switch (asciiBytes[1])
                        {
                            case 67: return "IS";    //
                            case 68: return "ID";    //
                            case 78: return "IN";    //
                            case 82: return "IR";    //
                            case 83: return "IL";    //
                            case 84: return "IT";    //
                            case 86: return "CI";    //
                            case 90: return "IQ";    //
                            default: return defaultResult;
                        }
                    }
                case 74:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "JP";    //
                            case 77: return "JM";    //
                            case 79: return "JO";    //
                            default: return defaultResult;
                        }
                    }
                case 75:
                    {
                        switch (asciiBytes[1])
                        {
                            case 69: return "KE";    //
                            case 71: return "KG";    //
                            case 78: return "KP";    //
                            case 82: return "KI";    //
                            case 83: return "KR";    //
                            case 84: return "CX";    //
                            case 85: return "KW";    //
                            case 90: return "KZ";    //
                            default: return defaultResult;
                        }
                    }
                case 76:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "LA";    //
                            case 69: return "LB";    //
                            case 71: return "LV";    //
                            case 72: return "LT";    //
                            case 73: return "LR";    //
                            case 79: return "SK";    //
                            case 83: return "LI";    //
                            case 84: return "LS";    //
                            case 85: return "LU";    //
                            case 89: return "LY";    //
                            default: return defaultResult;
                        }
                    }
                case 77:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "MG";    //
                            case 66: return "MQ";    //
                            case 67: return "MO";    //
                            case 68: return "MD";    //
                            case 70: return "YT";    //
                            case 71: return "MN";    //
                            case 73: return "MW";    //
                            case 74: return "MS";    //
                            case 75: return "MK";    //
                            case 76: return "ML";    //
                            case 78: return "MC";    //
                            case 79: return "MA";    //
                            case 80: return "MU";    //
                            case 82: return "MR";    //
                            case 84: return "MT";    //
                            case 85: return "OM";    //
                            case 86: return "MV";    //
                            case 87: return "ME";    //
                            case 88: return "MX";    //
                            case 89: return "MY";    //
                            case 90: return "MZ";    //
                            default: return defaultResult;
                        }
                    }
                case 78:
                    {
                        switch (asciiBytes[1])
                        {
                            case 67: return "NC";    //
                            case 69: return "NU";    //
                            case 70: return "NF";    //
                            case 71: return "NE";    //
                            case 72: return "VU";    //
                            case 73: return "NG";    //
                            case 76: return "NL";    //
                            case 79: return "NO";    //
                            case 80: return "NP";    //
                            case 82: return "NR";    //
                            case 83: return "SR";    //
                            case 84: return "AN";    //
                            case 85: return "NI";    //
                            case 90: return "NZ";    //
                            default: return defaultResult;
                        }
                    }
                case 79:
                    {
                        switch (asciiBytes[1])
                        {
                            case 67: return "NC";    //
                            case 69: return "NU";    //
                            case 70: return "NF";    //
                            case 71: return "NE";    //
                            case 72: return "VU";    //
                            case 73: return "NG";    //
                            case 76: return "NL";    //
                            case 79: return "NO";    //
                            case 80: return "NP";    //
                            case 82: return "NR";    //
                            case 83: return "SR";    //
                            case 84: return "AN";    //
                            case 85: return "NI";    //
                            case 90: return "NZ";    //
                            default: return defaultResult;
                        }
                    }
                case 80:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "PY";    //
                            case 67: return "PN";    //
                            case 69: return "PE";    //
                            case 75: return "PK";    //
                            case 76: return "PL";    //
                            case 77: return "PA";    //
                            case 79: return "PT";    //
                            case 80: return "PG";    //
                            case 83: return "PW";    //
                            case 85: return "GW";    //
                            default: return defaultResult;
                        }
                    }
                case 81:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "QA";    //
                            default: return defaultResult;
                        }
                    }
                case 82:
                    {
                        switch (asciiBytes[1])
                        {
                            case 69: return "RE";    //
                            case 73: return "RS";    //
                            case 77: return "MH";    //
                            case 79: return "RO";    //
                            case 80: return "PH";    //
                            case 81: return "PR";    //
                            case 83: return "RU";    //
                            case 87: return "RW";    //
                            default: return defaultResult;
                        }
                    }
                case 83:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "SA";    //
                            case 66: return "PM";    //
                            case 67: return "KN";    //
                            case 69: return "SC";    //
                            case 70: return "ZA";    //
                            case 71: return "SN";    //
                            case 72: return "SH";    //
                            case 73: return "SI";    //
                            case 76: return "SL";    //
                            case 77: return "SM";    //
                            case 78: return "SG";    //
                            case 79: return "SO";    //
                            case 80: return "ES";    //
                            case 84: return "LC";    //
                            case 85: return "SD";    //
                            case 86: return "SJ";    //
                            case 87: return "SE";    //
                            case 88: return "GS";    //
                            case 89: return "SY";    //
                            case 90: return "CH";    //
                            default: return defaultResult;
                        }
                    }
                case 84:
                    {
                        switch (asciiBytes[1])
                        {
                            case 68: return "TT";    //
                            case 72: return "TH";    //
                            case 73: return "TJ";    //
                            case 75: return "TC";    //
                            case 76: return "TK";    //
                            case 78: return "TO";    //
                            case 79: return "TG";    //
                            case 80: return "ST";    //
                            case 83: return "TN";    //
                            case 84: return "TL";    //
                            case 85: return "TR";    //
                            case 86: return "TV";    //
                            case 87: return "TW";    //
                            case 88: return "TM";    //
                            case 90: return "TZ";    //
                            default: return defaultResult;
                        }
                    }
                case 85:
                    {
                        switch (asciiBytes[1])
                        {
                            case 71: return "UG";    //
                            case 75: return "GB";    //
                            case 80: return "UA";    //
                            case 83: return "US";    //
                            case 86: return "BF";    //
                            case 89: return "UY";    //
                            case 90: return "UZ";    //
                            default: return defaultResult;
                        }
                    }
                case 86:
                    {
                        switch (asciiBytes[1])
                        {
                            case 67: return "VC";    //
                            case 69: return "VE";    //
                            case 71: return "VI";    //
                            case 73: return "VG";    //
                            case 77: return "VN";    //
                            case 81: return "VI";    //
                            case 84: return "VA";    //
                            //case 84: return "VA";    //
                            default: return defaultResult;
                        }
                    }
                case 87:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "NA";    //
                            case 69: return "PS";    //WE - West Bank
                            case 70: return "WF";    //
                            case 73: return "EH";    //
                            case 83: return "WS";    //
                            case 90: return "SZ";    //
                            default: return defaultResult;
                        }
                    }
                case 89:
                    {
                        switch (asciiBytes[1])
                        {
                            case 77: return "YE";    //
                            default: return defaultResult;
                        }
                    }
                case 90:
                    {
                        switch (asciiBytes[1])
                        {
                            case 65: return "ZM";    //
                            case 73: return "ZW";    //
                            default: return defaultResult;
                        }
                    }
            }

            return defaultResult;
            /*
            gz, we	103,122	PS	PSE	Palestine	275
             */



        }
    }

}
