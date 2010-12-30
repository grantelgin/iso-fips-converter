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
}