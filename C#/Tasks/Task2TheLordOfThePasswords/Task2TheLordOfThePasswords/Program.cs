
bool isAgain = true;
while (isAgain)
{
    try
    {
        string username = getUsernameFromUser();
        while (true)
        {
            string password = getPasswordFromUser();
            bool isTooLength = checkPasswordLength(password);
            if (isTooLength)
            {
                string passwordStrength = checkPasswordStrength(password);
                Console.WriteLine($"{passwordStrength} şifre!");
                break;
            }
        }
        isAgain = false;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bilinmeyen bir hatayla karşılaşıldı. \nBi bakayım diyorsan hata kodu:\n" + ex + "\n");
        isAgain = true;
    }
}

string checkPasswordStrength(string password)
{
    bool isLetter = false;
    bool isNumber = false;
    bool isNonAlfanumeric = false;
    for (int i = 0; i < password.Length; i++)
    {
        if (!isLetter)
        {
            isLetter = char.IsLetter(password[i]);
        }
        if (!isNumber)
        {
            isNumber = char.IsNumber(password[i]);
        }
        if (!isNonAlfanumeric)
        {
            isNonAlfanumeric = char.IsSymbol(password[i]) || char.IsPunctuation(password[i]);
        }
    }

    if (isNonAlfanumeric && isNumber && isLetter)
    {
        return "İYİ";
    }
    else if ((isLetter && isNumber) || (isLetter && isNonAlfanumeric) || (isNumber && isNonAlfanumeric))
    {
        return "KÖTÜ";
    }
    else
    {
        return "ÇİRKİN";
    }
}

bool checkPasswordLength(string password)
{
    bool isTooLength = true;
    if (password.Length < 6)
    {
        Console.WriteLine("Şifre 6 karakterden küçük olamaz");
        isTooLength = false;
    }
    return isTooLength;
}


string getUsernameFromUser()
{
    Console.Write("Kullanıcı adınızı giriniz: ");
    return Console.ReadLine();
}

string getPasswordFromUser()
{
    Console.Write("Şifrenizi giriniz: ");
    return Console.ReadLine();
}
