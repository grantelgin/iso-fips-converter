using System;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for StringLib
/// </summary>
public static class StringLib
{
    public static string PadInt(int i, int maxWidth)
    {
        int diffLen = maxWidth - i.ToString().Length;
        if (diffLen <= 0) return i.ToString();
        string s = new string('0', diffLen);
        return string.Format("{0}{1}", s, i);
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

    public static int GetCRandomNum(int min, int max)
    {
        if (max == min) return min;
        byte[] randomNumber = new byte[4];
        RNGCryptoServiceProvider Gen = new RNGCryptoServiceProvider();
        Gen.GetBytes(randomNumber);
        int rand = Math.Abs(BitConverter.ToInt32(randomNumber, 0));
        return Math.Abs(min + (rand % (max - min)));
    }
}