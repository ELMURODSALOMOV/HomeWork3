string str = "telefOn";
System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > str.Length)
{
    System.Console.WriteLine(str.ToUpper());
}
else
{
    System.Console.WriteLine(str.ToLower());
}

int x = 15;
int y = 10;
string result;

if (x > y)
{
    result = "x is greater than y";
}
else if (x < y)
{
    result = "x is less than y";
}
else if (x == y)
{
    result = "x is equal to y";
}
else
{
    result = "x and y are not comparable";
}

Console.WriteLine(result);

Console.Write("Hafta kunini kiriting (o'zbek tilida): ");
        string haftaKuni = Console.ReadLine().ToLower();

        string haftaKuniInglizTilida = haftaKuni switch
        {
            "dushanba" => "Monday",
            "seshanba" => "Tuesday",
            "chorshanba" => "Wednesday",
            "payshanba" => "Thursday",
            "juma" => "Friday",
            "shanba" => "Saturday",
            "yakshanba" => "Sunday",
            _ => "Noto'g'ri kiritish"
        };

        Console.WriteLine($"Hafta kunining ingliz tilidagi nomi: {haftaKuniInglizTilida}");