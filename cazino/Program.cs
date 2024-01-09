using System;

class Casino
{
    static int balance = 1000;

    static void Main()
    {
        Console.WriteLine("Ласкаво просимо до казино!");

        while (balance > 0)
        {
            Console.WriteLine($"Ваш баланс: {balance}");
            Console.WriteLine("Оберіть гру:");
            Console.WriteLine("1. Рулетка");
            Console.WriteLine("2. Слот-машини");
            Console.WriteLine("3. Вийти");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Ruletka();
                    break;

                case 2:
                    Slotu();
                    break;

                case 3:
                    Console.WriteLine("Дякую за гру. До побачення!");
                    return;

                default:
                    Console.WriteLine("Некоректний вибір. Спробуйте знову.");
                    break;
            }
        }

        Console.WriteLine("Ваш баланс сповнено. Дякую за гру!");
    }

    static void Ruletka()
    {
        Console.WriteLine("Ви граєте в рулетку. Скільки ви ставите?");
        int bet = Convert.ToInt32(Console.ReadLine());

        if (bet > balance)
        {
            Console.WriteLine("Недостатньо грошей на балансі.");
            return;
        }

        Random random = new Random();
        int result = random.Next(1, 7);
        Console.WriteLine("Вгадайте число від 1 до 7");
        int chislo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Випало число: {result}");

        if (chislo == result) {
            Console.WriteLine($"Ви виграли! Ваш виграш -> {bet * 2}");
            balance += bet;
        }

        else
        {
            Console.WriteLine("Ви програли :(");
            balance -= bet;
        }
    }

    static void Slotu()
    {
        Console.WriteLine("Ви граєте в слот-машини. Скільки ви ставите?");
        int bet = Convert.ToInt32(Console.ReadLine());

        if (bet > balance)
        {
            Console.WriteLine("Недостатньо грошей на балансі.");
            return;
        }

        Random random = new Random();
        int cufra1 = random.Next(1, 4);
        int cufra2 = random.Next(1, 4);
        int cufra3 = random.Next(1, 4);

        Console.WriteLine($"Цифри на барабанах: {cufra1}, {cufra2}, {cufra3}");

        if (cufra1 == cufra2 && cufra2 == cufra3)
        {
            Console.WriteLine($"Ви виграли! Ваш виграш: {bet * 3}");
            balance += bet * 2;
        }
        else
        {
            Console.WriteLine("Ви програли :(");
            balance -= bet;
        }
    }
}
