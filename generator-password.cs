using System;

class GneratePassword
{
    private const  string CharSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private static Random random = new Random();

    public static string GneratePassword(int length)
    {
        char password = new char [length];
        for (int i = 0; i < length; i++)
        {
            password[i] =  CharSet[random.Next(CharSet.Length)];
        }
        return  new string(password);
    }
    static void Main()
    {
        int passwordLength = 8;
        string password = GneratePassword(passwordLength);
        Console.WriteLine("Сгенерировать пароль" + password);
    }
}