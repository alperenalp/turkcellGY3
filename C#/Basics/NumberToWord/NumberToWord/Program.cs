/*
 * 42
 * Kırk iki
 * 
 * 52418
 * 
 * 13.695.598
 * 
 * 1453
 */

string[] tens = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] ones = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] layers = { "bin", "milyon", "trilyon", "katrilyon" };

Console.WriteLine("Bir sayı giriniz");
string wordOfNumber = Console.ReadLine();
int numberLength = wordOfNumber.Length;
int number = Convert.ToInt32(wordOfNumber);
int[] numberArray = new int[numberLength];
int lastIndexOfNumber = numberLength - 1;
int number2 = number;
int counter = 0;
int counter2 = 0;
string hundered = "yüz";
while (number != 0)
{
    if (counter == 3)
    {
        hundered = layers[counter2];
    }
    int digit = number % 10;
    numberArray[lastIndexOfNumber] = digit;
    number = number / 10;
    counter++;
}


////453
//int digitLayer = number2 / 3;
//while (digitLayer > 0)
//{
//    Console.WriteLine($"{ones[numberArray[0]]}")
//}

