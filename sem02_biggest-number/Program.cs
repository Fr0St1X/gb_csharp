Console.Write("Day mne pervoe chislo: ");
    double FirstNumber = double.Parse(Console.ReadLine());
Console.Write("A teper skormi vtoroe: ");
    double SecondNumber = double.Parse(Console.ReadLine());

if(FirstNumber > SecondNumber)
    {
        Console.Write(FirstNumber);
        Console.Write(" bol'she ");
        Console.WriteLine(SecondNumber);
    }
else
    {
        Console.Write(FirstNumber);
        Console.Write(" men'she ");
        Console.WriteLine(SecondNumber);
    }