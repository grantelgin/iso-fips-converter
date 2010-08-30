using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;



namespace TestApp
{
    public partial class Form1 : Form
    {
        string[] arr_isos = { "AD", "AE", "AF", "AG", "AI", "AL", "AM", "AN", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "ME", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RS", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TL", "TM", "TN", "TO", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "US", "UY", "UZ", "VA", "VA", "VC", "VE", "VG", "VI", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "ZA", "ZM", "ZW" };
        string[] arr_fips = { "AN", "AE", "AF", "AC", "AV", "AL", "AM", "NT", "AO", "AY", "AR", "AQ", "AU", "AS", "AA", "AJ", "BK", "BB", "BG", "BE", "UV", "BU", "BA", "BY", "BN", "BD", "BX", "BL", "BR", "BF", "BT", "BC", "BO", "BH", "CA", "CK", "CG", "CT", "CF", "SZ", "IV", "CW", "CI", "CM", "CH", "CO", "CS", "CU", "CV", "KT", "CY", "EZ", "GM", "DJ", "DA", "DO", "DR", "AG", "EC", "EN", "EG", "WI", "ER", "SP", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GB", "UK", "GJ", "GG", "FG", "GH", "GI", "GL", "GA", "GV", "GP", "EK", "GR", "SX", "GT", "GQ", "PU", "GY", "HK", "HO", "HR", "HA", "HU", "ID", "EI", "IS", "IN", "IZ", "IR", "IC", "IT", "JM", "JO", "JA", "KE", "KG", "CB", "KR", "CN", "SC", "KN", "KS", "KU", "CJ", "KZ", "LA", "LE", "ST", "LS", "CE", "LI", "LT", "LH", "LU", "LG", "LY", "MO", "MN", "MD", "MW", "MA", "RM", "MK", "ML", "BM", "MG", "MC", "CQ", "MB", "MR", "MJ", "MT", "MP", "MV", "MI", "MX", "MY", "MZ", "WA", "NC", "NG", "NF", "NI", "NU", "NL", "NO", "NP", "NR", "NE", "NZ", "MU", "PM", "PE", "FP", "PP", "RP", "PK", "PL", "SB", "PC", "RQ", "GZ", "PO", "PS", "PA", "QA", "RE", "RO", "RI", "RS", "RW", "SA", "BP", "SE", "SU", "SW", "SN", "SH", "SI", "SV", "LO", "SL", "SM", "SG", "SO", "NS", "TP", "ES", "SY", "WZ", "TK", "CD", "FS", "TO", "TH", "TI", "TL", "TT", "TX", "TS", "TN", "TU", "TD", "TV", "TW", "TZ", "UP", "UG", "US", "UY", "UZ", "VT", "VT", "VC", "VE", "VI", "VG", "VQ", "VM", "NH", "WF", "WS", "YM", "MF", "SF", "ZA", "ZI" };

        private struct CountryData
        {
            public string Name;
            public string ISO2;
            public string ISO3;
            public Int16 ISONum;
            public string Fips;
            public bool populated;
        }

        private string[] parts;

        public Form1()
        {
            InitializeComponent();
        }

        private int GetCRandomNum(int min, int max)
        {
            if (max == min)
                return min;

            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[4];

            // Create a new instance of the RNGCryptoServiceProvider.
            RNGCryptoServiceProvider Gen = new RNGCryptoServiceProvider();

            // Fill the array with a random value.
            Gen.GetBytes(randomNumber);

            // Convert the byte to an integer value to make the modulus operation easier.
            int rand = Math.Abs(BitConverter.ToInt32(randomNumber, 0));

            // Return the random number mod the number
            // of sides.  The possible values are zero-
            // based, so we add one.
            return Math.Abs(min + (rand % (max - min)));
        }

        private CountryData ParseLine(string s)
        {
            CountryData cd = new CountryData();
            cd.populated = false;
            Int16 num = 0;

            try
            {
                this.parts = s.Split('\t');
                
                cd.ISO2 = this.parts[0];
                cd.ISO3 = this.parts[1];

                if (!Int16.TryParse(this.parts[2], out num))
                {
                    cd.ISONum = 0;
                }
                else
                {
                    cd.ISONum = num;
                }

                cd.Fips = this.parts[3];
                cd.Name = this.parts[4];
                cd.populated = true;
                return cd;
            }
            catch
            {
                return cd;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res=string.Empty;

            int times = 1000000;

            TimeSpan ts1;
            DateTime t1, t2;


            StringBuilder sb = new StringBuilder();

            int i=0;
            int rand = 0;




            t1 = DateTime.Now;
            rand = StringLib.GetCRandomNum(0, arr_isos.Length);
            for (i = 0; i < times; i++)
            {
                //res = ISO2ToFIPSConvertor.GetFipsCode(arr_isos[StringLib.GetCRandomNum(0, arr_isos.Length)]);
                res = ISO2ToFIPSConvertor.GetFipsCode(arr_isos[rand]);
            }

            t2 = DateTime.Now;
            ts1 = t2-t1;
            sb.Append(String.Format("{0} ISO2ToFIPSConvertor lookups done in {1} ms.", i, ts1.TotalMilliseconds));


            t1 = DateTime.Now;
            rand = StringLib.GetCRandomNum(0, arr_fips.Length);
            for (i = 0; i < times; i++)
            {
                res = FIPSToISO2Convertor.GetISO2Code(arr_fips[rand]);
            }

            t2 = DateTime.Now;
            ts1 = t2 - t1;
            sb.Append(String.Format("{0}{1} FIPSToISO2Convertor lookups done in {2} ms.", Environment.NewLine, i, ts1.TotalMilliseconds));

            textBox2.Text = sb.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
