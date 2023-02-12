Console.Write("Daj mne kvadrat chisla: ");
    double UserSquaredNumber = double.Parse(Console.ReadLine());

Console.Write("Otlichno! A teper' daj mne samo chislo: ");
    double UserRegularNumber = double.Parse(Console.ReadLine());
double Result = UserSquaredNumber/UserRegularNumber;

if (Result % 1 == 0 )
    {
        Console.WriteLine(" ");
        Console.WriteLine("Ne obmanul! Ty mne nravish'sya.\nYa ub'yu tebya poslednim!");
    }
else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Ya dlya tebya kakya-to shutka? Skoro pridet moy chas,\ni ti za vsyo otvetish, kozhanniy meshok!");
    }
