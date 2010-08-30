using System;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections;


/// <summary>
/// Summary description for StringLib
/// </summary>
public static class StringLib
{
    //4 stores means THERE MUST BE 4 chars in values string, etc.
    //public static string[] OnlineMusicStoreNames ={ "Amazon", "Emusic", "iTunes", "Rhapsody" };
    //public static string OnlineMusicStoreValues ="aeir";


    //public static string[] OnlineMusicStoreNames ={ "Amazon", "Emusic", "iTunes", "Rhapsody" };
    //public static string OnlineMusicStoreValues = "aeir";

    public static bool IsDouble(string doubleStr)
    {
        double d = 0.0;
        return double.TryParse(doubleStr, out d);
    }
    public static double StrToDoubleDef(string doubleStr, double defaultValue)
    {
        double d = 0.0;
        if (double.TryParse(doubleStr, out d))
        {
            return d;
        }
        else
        {
            return defaultValue;
        }
    }

    public static string PadInt(int i, int maxWidth)
    {
        int diffLen = maxWidth - i.ToString().Length;
        if (diffLen <= 0) return i.ToString();
        string s = new string('0', diffLen);
        return string.Format("{0}{1}", s, i);
    }


 



    public static string[] MonthsOfTheYear ={ String.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    public static string[] MonthsOfTheYearShort ={ String.Empty, "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };




    public static string[] pageNames ={"",
                                        "article.aspx",
                                        "artists.aspx",
                                        "default.aspx",
                                        "download.aspx",
                                        "friendreq.aspx",
                                        "friends.aspx",
                                        "mixplay.aspx",
                                        "mixtapecreate.aspx",
                                        "mixtapeplay.aspx",
                                        "mymixes.aspx",
                                        "mystats.aspx",
                                        "mystuff.aspx",
                                        "promocreate.aspx",
                                        "search.aspx",
                                        "sentmsgs.aspx",
                                        "track_upload.aspx",
                                        "usereditprofile.aspx",
                                        "userprofile.aspx",
                                        "users.aspx"};


    public static string[] pageActivities  ={""
                                            ,"Reading a news article"
                                            ,"Managing favorite artists"
                                            ,"Browsing the homepage"
                                            ,"Downloading Rocudo software"
                                            ,"Managing friend requests"
                                            ,"Managing friends"
                                            ,"Listening to a Remix"
                                            ,"Creating a Mix"
                                            ,"Playing a Mix"
                                            ,"Managing/Viewing Remixes"
                                            ,"Viewing Stats"
                                            ,"Viewing MyStuff"
                                            ,"Creating a Promo"
                                            ,"Searching Rocudo.com"
                                            ,"Managing Outbox"
                                            ,"Managing tracks"
                                            ,"Editing personal profile"
                                            ,"Viewing a personal profile"
                                            ,"Searching Rocudo.com"};












    private static string[] userAgents = { "explorer", "gecko", "opera", "safari", "konqueror" };
    private static string[] oses = { "windows", "mac os", "linux" };



    //private static Regex isGuid = new Regex(@"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$", RegexOptions.Compiled);
    //private static string PWLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //private static string PWNumbers = "0123456789";
    //private static string PWSpecialChars = "-_!";
    private static string PWAllChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.-_![]{}?$&£#";
    private static string UsernameChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.-_![]{}?$&";
    private static string EntitynameChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.-_![]{}?$& ,£";

    public enum SiteAreaContext
    {
        Homepage,
        Remixes,
        MyStuff,
        Artists,
        Promos,
        EditProfile,
        ViewProfile,
        Friends,
        Stats,
        Search,
        Tracks,
        ManageArtists,
        Clips,
        Fans,
        Nowhere
    }


    public struct NameIntPair
    {
        public int Number;
        public string Name;
        public string Positioning;
    }

    public struct StringPair
    {
        public string EntityName;
        public string Username;
    }

    public struct AuthCookieValues
    {
        public int Id;
        public string StoredPassword;
    }

    public struct AuthCookieValuesSession
    {
        public int Id;
        public string SessionId;
    }


    public static string ActivitityNameFromPageName(string pageName)
    {
        pageName = pageName.ToLower();
        int index = Array.IndexOf(StringLib.pageNames, pageName);

        if ((index < 0) || (index > pageActivities.Length - 1))
        {
            return string.Empty;
        }
        else
        {
            return StringLib.pageActivities[Array.IndexOf(StringLib.pageNames, pageName)];
        }
    }

    public static int ActivitityNumberFromPageName(string pageName)
    {
        if (pageName.Length == 0)
            return 0;


        pageName = pageName.ToLower();
        int index = Array.IndexOf(StringLib.pageNames, pageName);

        if ((index < 0) || (index > pageActivities.Length - 1))
        {
            return 0;
        }
        else
        {
            return index;
        }
    }

    public static string ActivitityNameFromActivitityNumber(int actNum)
    {
        if ((actNum < 0) || (actNum > pageActivities.Length - 1))
        {
            return string.Empty;
        }
        else
        {
            return pageActivities[actNum];
        }
    }



 



    public static string StringReplace(string s, string OldPattern, string NewPattern)
    {
        if ((OldPattern == null) || (NewPattern == null) || (s == null))
        {
            return string.Empty;
        }
        else return s.Replace(OldPattern, NewPattern);
    }


    public static int GetRandomNum(int min, int max)
    {
        Random RandomClass = new Random(Convert.ToInt32(DateTime.Now.Ticks % 2100000000));

        if (min >= max)
        {
            min = max - 1;
        }

        return RandomClass.Next(min, max);
    }








	public static string MD5String(string s)
    {
        // First we need to convert the string into bytes, which
        // means using a text encoder.
        Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

        // Create a buffer large enough to hold the string
        byte[] unicodeText = new byte[s.Length * 2];
        enc.GetBytes(s.ToCharArray(), 0, s.Length, unicodeText, 0, true);

        // Now that we have a byte array we can ask the CSP to hash it
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] result = md5.ComputeHash(unicodeText);

        // Build the final string by converting each byte
        // into hex and appending it to a StringBuilder
        StringBuilder sb = new StringBuilder();
        for (int i=0;i<result.Length;i++)
        {
            sb.Append(result[i].ToString("X2"));
        }

        // And return it
        return sb.ToString();
    }









    public static string SHA1String(string s)
    {
        // First we need to convert the string into bytes, which
        // means using a text encoder.
        Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

        // Create a buffer large enough to hold the string
        byte[] unicodeText = new byte[s.Length * 2];
        enc.GetBytes(s.ToCharArray(), 0, s.Length, unicodeText, 0, true);

        // Now that we have a byte array we can ask the CSP to hash it
        SHA1 sha1 = new SHA1CryptoServiceProvider();
        byte[] result = sha1.ComputeHash(unicodeText);

        // Build the final string by converting each byte
        // into hex and appending it to a StringBuilder
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < result.Length; i++)
        {
            sb.Append(result[i].ToString("X2"));
        }

        // And return it
        return sb.ToString();
    }
























    public static bool IsValidEmailFormat(string emailAddress)
    {
        emailAddress = emailAddress.Trim();
        if (emailAddress == null)
        {
            return false;
        }
        else if ((emailAddress.Length == 0)||(emailAddress.Length > 60))
        {
            return false;
        }
        else
        {
            return Regex.IsMatch(emailAddress, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnorePatternWhitespace);
        }
    }

    public static bool IsValidUsername(string username)
    {
        username = username.Trim();

        if ((username.Length < 3)||(username.Length > 20))
        {
            return false;
        }

        foreach (char c in username)
        {
            if(StringLib.UsernameChars.IndexOf(c)<0)
            {
                return false;
            }
        }

        if (username.IndexOf("--") >= 0)
            return false;

        return true;
    }


    public static bool IsValidArtistOrLabelName(string entityname)
    {
        entityname = entityname.Trim();

        if ((entityname.Length < 1) || (entityname.Length > 50))
        {
            return false;
        }

        foreach (char c in entityname)
        {
            if (StringLib.EntitynameChars.IndexOf(c) < 0)
            {
                return false;
            }
        }
        return true;
    }


   


    public static string GetNewConfirmCode()
    {
        return Guid.NewGuid().ToString();
    }


    public static string Reverse(string str)
    {

        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);









        //// convert the string to char array
        //char[] charArray = str.ToCharArray();
        //int len = str.Length - 1;
        ///*
        //now this for is a bit unconventional at first glance because there
        //are 2 variables that we're changing values of: i++ and len--.
        //the order of them is irrelevant. so basicaly we're going with i from 
        //start to end of the array. with len we're shortening the array by one
        //each time. this is probably understandable.
        //*/
        //for (int i = 0; i < len; i++, len--)
        //{
        //    /*
        //    now this is the tricky part people that should know about it don't.
        //    look at the table below to see what's going on exactly here.
        //    */
        //    charArray[i] ^= charArray[len];
        //    charArray[len] ^= charArray[i];
        //    charArray[i] ^= charArray[len];
        //}
        //return new string(charArray);
    }


    public static string GetUniqueString(int maxSize)
    {
        char[] chars = new char[40];
        chars =
        "abcdefghijklmnopqrstuvwxyz0123456789-_$!".ToCharArray();
        byte[] data = new byte[1];
        RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
        crypto.GetNonZeroBytes(data);
        data = new byte[maxSize];
        crypto.GetNonZeroBytes(data);
        StringBuilder result = new StringBuilder(maxSize);
        foreach (byte b in data)
        {
            result.Append(chars[b % (chars.Length - 1)]);
        }
        return result.ToString();
    }



    public static string GetStringPart(string s, char delimiter, int partnum)
    {
        char[] delim = { delimiter };
        string[] parts = s.Split(delim);

        if (partnum > parts.Length)
        {
            return string.Empty;
        }
        else
        {
            return parts[partnum];
        }

    }

    public static string RemoveFileExtension(string fileName)
    {
        int i = fileName.LastIndexOf('.');

        if (i < 0)
        {
            return fileName;
        }
        else
        {
            return fileName.Substring(0, i);
        }
    }

    public static char GetFirstDBChar(Object o)
    {
        string asString = o.ToString();
        if ((o.Equals(System.DBNull.Value)) || (asString.Length== 0))
        {
            return 'n';
        }
        else
        {
            return asString[0];
        }
    }
  
    public static string DBNullToString(Object o)
    {
        if (o == null)
        {
            return string.Empty;
        }
        else if (o.Equals(System.DBNull.Value))
        {
            return string.Empty;
        }
        else
        {
            return o.ToString();
        }
    }


    public static int DBNullToInt(Object o)
    {
        if (o == null)
        {
            return 0;
        }
        else if (o.Equals(System.DBNull.Value))
        {
            return 0;
        }
        else
        {
            int res=0;

            if(!int.TryParse(o.ToString(), out res))
            {
                return 0;
            }
            else
            {
                return res;
            }
        }
    }

    public static DateTime DBNullToDateTime(object o)
    {
        if((o==null)||(o.Equals(System.DBNull.Value)))
            return new DateTime(1900, 1, 1);
        else
        {
            try
            {
                return (DateTime)o;
            }
            catch
            {
                return new DateTime(1900, 1, 1);
            }
        }
    }

    public static string DBNullToStringDef(Object o, string defaultStr)
    {
        if (o == null)
        {
            return defaultStr;
        }
        else if (o.Equals(System.DBNull.Value))
        {
            return defaultStr;
        }
        else
        {
            return o.ToString();
        }
    }

    public static string NullToString(Object o)
    {
        if (o==null)
        {
            return string.Empty;
        }
        else
        {
            return o.ToString();
        }
    }


    public static bool IsInt(string s)
    {
        if (s == null)
        {
            return false;
        }
        int num = 0;
        return int.TryParse(s, out num);
    }

    public static bool IsIntInRange(string s, int iLow, int iHigh)
    {
        int num = 0;
        if (int.TryParse(s, out num))
        {
            return ((num >= iLow) && (num <= iHigh));
        }
        else
        {
            return false;
        }
    }

    public static string[] RemoveDuplicateStrings(string[] strs, bool trimStrings, bool sortResult)
    {
        if (trimStrings)
        {
            for ( int i = 0 ; i < strs.Length ; i++ )
            {
                strs[i] = strs[i].Trim();
            }
        }


        StringCollection sc = new StringCollection();

        for (int i = 0; i < strs.Length; i++)
        {
            if (ScContainsStrNoCase(ref sc, strs[i]))
                continue;
           
            sc.Add(strs[i]);
        }

        strs = new string[sc.Count];

        for( int i = 0 ; i < sc.Count ; i++ )
        {
            strs[i] = sc[i];
        }

        sc.Clear();

        if (sortResult)
            Array.Sort(strs);

        return strs;
    }

    public static bool ScContainsStrNoCase(ref StringCollection sc, string s)
    {
            foreach (string tmp in sc)
            {
                if (tmp.ToLower().CompareTo(s.ToLower()) == 0)
                    return true;
            }

            return false;
    }


    /*
     
     Fast remove duplcates
         static List<string> removeDuplicates(List<string> inputList)
        {
            List<string> finalList = new List<string>();
            foreach (string currValue in inputList)
            {
                if (!Contains(finalList, currValue))
                {
                    finalList.Add(currValue);
                }
            }
            return finalList;
        }
        static bool Contains(List<string> list, string comparedValue)
        {
            foreach(string listValue in list)
            {
                if (listValue == comparedValue)
                {
                    return true;
                }
            }
            return false;
        }
     
     */

    public static string GetNotMoreThanNChars(string s, int count)
    {
        if (s.Length >= count)
        {
            return s.Substring(0, count);
        }
        else
        {
            return s;
        }
    }

    public static string MinimizeSpaces(string s)
    {
        while (s.IndexOf("  ") >= 0)
        {
            s = s.Replace("  ", " ");
        }

        return s.Trim();
    }



    public static string StringCollToCSString(StringCollection sc)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string s in sc)
        {
            sb.Append(s + " ");
        }

        return sb.ToString().Trim();
    }




    public static bool StringIsNumeric(string s)
    {
        try
        {
            int i = Convert.ToInt32(s);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public static string GetSqlDateTimeStr(DateTime dt)
    {
        //18-11-2548 10:27:20
        return dt.ToString("dd-MM-yyyy H:mm:ss");
    }

    public static bool IsLegalPassword(string s)
    {
        if ((s.Length < 5) || (s.Length > 25))
        {
            return false;
        }

        foreach (char c in s)
        {
            if (StringLib.PWAllChars.IndexOf(c) < 0)
                return false;
        }

        return true;
    }

    public static bool IsGuid(string candidate)
    {
        if (candidate != null)
        {
            return Regex.Match(candidate, @"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$").Success;
        }
        else
        {
            return false;
        }
    }



    public static string GetTagListHyperLinks(string tags)
    {
        char[] sep ={ ',' };
        string[] tagArray;
        tags = tags.Replace(" ", string.Empty);
        tagArray = tags.Split(sep);
        StringBuilder sb = new StringBuilder();

        foreach (string s in tagArray)
        {
            sb.Append("<a href=\"news.aspx?tag=" + s + "\">" + s + "</a> &nbsp;");
        }

        return sb.ToString();
    }

    public static int StrToIntDef(string s, int d)
    {
        if (s == null) return d;
        int n = d;

        if (int.TryParse(s, out n))
        {
            return n;
        }
        else
            return d;
    }

    public static double KBToMB(int kb)
    {
        decimal mb = (decimal)kb / 1024;
        return (double)decimal.Round(mb, 1);
    }

    public static string KBToMBStr(int kb)
    {
        decimal mb = (decimal)kb / 1024;
        decimal d = decimal.Round(mb, 1);

        return d.ToString();
    }




    public static int[] GetIntsFromCommaString(string s)
    {
        char[] sep = { ',' };
        string[] selStrs = s.Split(sep);
        
        int temp;
        string tmpStr = string.Empty;

        int[] res = new int[selStrs.Length];

        for ( int i = 0 ; i < selStrs.Length ; i++ )
        {

            tmpStr = selStrs[i].Trim();

            if (int.TryParse(tmpStr, out temp))
            {
                res[i] = temp;
            }
            else
            {
                res = new int[1];
                res[0] = -1;
                return res; 
            }
        }

        return res;
    }

    public static string[] GetStringsFromCommaString(string s)
    {
        char[] sep = { ',' };
        return s.Split(sep);
    }

    public static bool RemixTrackPositioningIsValid(string trackPositioning)
    {
        if(trackPositioning==null)
           return false;

        if(trackPositioning.Length!=4)
            return false;
    
        string oneZero="01";
    

        for (int i=0;i<4;i++)
        {
            if(oneZero.IndexOf(trackPositioning[i])<0)
            {
                return false;
            }
        }

        return true;
    }

    private static string GetCharStringSection(string s, int sectNum, char seperator)
    {
        char[] sep = new char[1];//{ seperator };
        sep[0] = seperator;
        string[] sections = s.Split(sep);

        if (sections.Length <= sectNum)
        {
            return string.Empty;
        }

        return sections[sectNum].Trim();
    }

    public static string GetTextAfterComma(string s)
    {
        if (s == null)
        {
            return string.Empty;
        }

        int commaind = s.IndexOf(",");

        if (commaind >= 0)
        {
            return s.Substring(commaind + 1, s.Length - commaind - 1).Trim();
        }
        else
        {
            return string.Empty;
        }
    }

    public static string GetTextBeforeComma(string s)
    {
        if (s == null)
        {
            return string.Empty;
        }

        int commaind = s.IndexOf(",");

        if (commaind >= 0)
        {
            return s.Substring(0, commaind).Trim();
        }
        else
        {
            return string.Empty;
        }
    }

    public static string GetTextBeforeCommaDef(string s, string defaultValue)
    {
        string res = GetTextBeforeComma(s);

        if (String.Compare(res, string.Empty) == 0)
        {
            return defaultValue;
        }
        else return res;
    }

    public static string MakeFileNameSafe(string fileName)
    {
        fileName = fileName.Replace(":", "_");
        fileName = fileName.Replace("?", "_");
        fileName = fileName.Replace("\\", "_");
        fileName = fileName.Replace("*", "_");
        fileName = fileName.Replace("<", "_");
        fileName = fileName.Replace(">", "_");
        fileName = fileName.Replace("/", "_");
        fileName = fileName.Replace("|", "_");
        fileName = fileName.Replace("\"", "_");

        return fileName;
    }

    public static bool IsInteger(String strNumber)
    {
        Regex objIntPattern = new Regex("^[0-9]*$");
        return objIntPattern.IsMatch(strNumber);
    }

    public static bool IsIntegerString(String strNumber)
    {
        Regex objIntPattern = new Regex("^[0-9]*$");
        return objIntPattern.IsMatch(strNumber);
    }

    public static int GetCharCount(string s, char c)
    {
        int result = 0;
        foreach (char ch in s)
        {
            if (ch == c)
            {
                result++;
            }
        }

        return result;
    }


    public static string LimitStringLength(string s, int maxAllowedLength)
    {
        if (s == null)
        {
            return string.Empty;
        }
        else if (s.Length <= maxAllowedLength)
        {
            return s;
        }
        else
        {
            return s.Substring(0, maxAllowedLength).Trim();
        }
    }

    public static string LimitStringLengthEpsillon(string s, int maxAllowedLength)
    {
        const string el = "...";
        if (s == null)
        {
            return string.Empty;
        }
        else if (s.Length <= maxAllowedLength - 3)
        {
            return s;
        }
        else if (s.Length < 3)
        {
            return el;
        }
        else
        {
            return String.Concat(s.Substring(0, maxAllowedLength - 3).Trim(), el);
        }
    }



    public static bool DBNullToBool(object obj)
    {
        return DBNullToBoolDef(obj, false);
    }

    public static bool DBNullToBoolDef(object obj, bool defaultValue)
    {
        if(obj==null)
            return defaultValue;
        else if(obj.Equals(System.DBNull.Value))
            return defaultValue;
        else 
        {
            try
            {
                return (bool)obj;
            }
            catch
            {
                return defaultValue;
            }
        }
    }

    public static string SlugifyTitle(string title)
    {
        string replaceableChars = "?/\\><&\"!#%*+={}|~`., ";

        if (title == null)
            return StringLib.GetNewConfirmCode();


        title = title.ToLower();

        foreach (char c in replaceableChars)
        {
            if (title.IndexOf(c) >= 0)
            {
                title = title.Replace(c, '_');
            }
        }

        return String.Format("{0}_{1}", RandomIntegerString(5), title);
    }


    public static string RandomIntegerString(int size)
    {
        string charSet = "0123456789";
        StringBuilder builder = new StringBuilder();
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            builder.Append(charSet[random.Next(charSet.Length-1)]);
        }
        return builder.ToString();
    }





    public static int IntOverIntAsPercent(int enumerator, int denominator)
    {
        double d = Convert.ToDouble(denominator);
        double e = Convert.ToDouble(enumerator);
        return Convert.ToInt32(Math.Ceiling( (e / d) * 100));
    }


    public static string MakeUsernameFromEntityName(string EntityName)
    {
        EntityName = EntityName.Replace(" ", string.Empty);
        EntityName = EntityName.Replace(".", string.Empty);
        for (int i=0;i<EntityName.Length;i++)
        {
            if(UsernameChars.IndexOf(EntityName[i])<0)
            {
                EntityName = EntityName.Replace(EntityName[i], '_');
            }

        }
        Random random = new Random();
        string num = random.Next(100, 999).ToString();

        return StringLib.LimitStringLength(EntityName.ToLower(), 20 - num.Length) + num;
    }
  
    public static int BoolToOneZero(bool b)
    {
        if (b) return 1;
        else return 0;
    }


    public static string BoolToOneZeroStr(bool b)
    {
        if (b) return "1";
        else return "0";
    }

    public static string ExtractDomainNameFromURL(string Url)
    {
        int pos = Url.IndexOf("://");
        if (pos == -1 || pos > 5)
            Url = "http://" + Url;

        return new Uri(Url).Host;
    }

    public static void GetBrowserAndOs(string userAgent, out int browser, out int os)
    {

        if (userAgent == null)
        {
            browser = -1;
            os = -1;
            return;
        }

        userAgent = userAgent.ToLower();

        browser = -1;
        for (int i = 0; i < userAgents.Length; i++)
        {
            if (userAgent.IndexOf(userAgents[i]) >= 0)
            {
                browser = i;
                break;
            }
        }
        if (browser == -1)
            browser = 0;



        os = -1;
        for (int i = 0; i < oses.Length; i++)
        {
            if (userAgent.IndexOf(oses[i]) > 0)
            {
                os = i;
                break;
            }
        }
        if (os == -1)
            os = 0;



    }

    public static decimal GetBPMDoubleFromStr(string bpmStr)
    {
        decimal d = 0.0M;

        if (bpmStr == null)
            return d;

        if (!decimal.TryParse(bpmStr, out d))
        {
            return 0.0M;
        }
        else
        {
            d= Decimal.Round(d, 2);
        }

        if ((d > 180.0M) || (d < 60M)) return 0.0M;
        else return d;
    }


    /// <summary>
    /// Returns the number of somma seperated integers in the string. Returns -1 if the 
    /// string does not consist purely of comma seperated integers. (spaces are allowed in string)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int StringIsCommaDelimitedIntegers(string s)
    {
        if (s == null)return -1;

        s = s.Trim();
        
        if(s.Length==0) return -1;
    
        s = s.Replace(" ", string.Empty);
        int test=0;

        string[] parts = s.Split(',');

        foreach(string temp in parts)
        {
            try
            {
                if (!int.TryParse(temp, out test))
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }
        return parts.Length;
    }

    public static bool StringIsCommaSeparatedIntegers(string s)
    {
        if (s == null) return false;

        char[] sep ={ ',' };
        string[] selStrs = s.Split(sep);
        int temp;
        string tmpStr = string.Empty;

        foreach (string str in selStrs)
        {
            tmpStr = str.Trim();

            if (!int.TryParse(tmpStr, out temp))
            {
                return false;
            }
        }

        return true;
    }



    public static int BoolToOneOrZero(bool b)
    {
        if (b)
            return 1;
        else return 0;
    }




    public static string StringArrayToString(string[] strs, string seperator)
    {
        StringBuilder sb = new StringBuilder();
        bool isSeperator = seperator.Length>0;

        foreach (string s in strs)
        {
            if(isSeperator)
                sb.Append(String.Format("{0}{1}", s, seperator));
            else
                sb.Append(s);
        }

        return sb.ToString();
    }

    public static string ColorToHtmlStr(System.Drawing.Color c)
    {
        return System.Drawing.ColorTranslator.ToHtml(c);
    }

    public static System.Drawing.Color HtmlStrToColor(string HtmlColor)
    {
        try
        {
            return System.Drawing.ColorTranslator.FromHtml(HtmlColor);
        }
        catch//(Exception ex)
        {
            return System.Drawing.Color.Black;
        }
    }

    public static string GetTrackIdsFromActionReport(string[] actionReports)
    {
        StringBuilder sb = new StringBuilder();

        try
        {
            for( int i = 0; i < actionReports.Length ; i++ )
            {
                if(i>0)
                {
                    sb.Append(String.Format(",{0}", StringLib.GetTextBeforeCommaDef(actionReports[i], "0")));
                }
                else
                {
                    sb.Append(StringLib.GetTextBeforeCommaDef(actionReports[i], "0"));
                }
            }
        }
        catch
        {

        }

        return sb.ToString();
    }


    public static int GetCRandomNum(int min, int max)
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


   
    public static string ChangeFileExtension(string fileName, string newExt)
    {
        return System.IO.Path.ChangeExtension(fileName, newExt);
    }

    public static bool IsAuthCookieValueFormat(string candidate)
    {
        if (candidate != null)
        {
            return Regex.Match(candidate, @"^[0-9a-fA-F\-]{36}(\,){1}[0-9]{1,20}$").Success;
        }
        else
        {
            return false;
        }
    }


}