using System;

internal class Program
{
    static void Main(string[] args)
    {
        float balanceRUB = 10000f;
        float balanceUSD = 500f;
        float balanceEUR = 500f;
        float rubToUsd = 0.0134f;
        float rubToEur = 0.0127f;
        float usdToRub = 74.3935f;
        float usdToEur = 0.9450f;
        float eurToRub = 78.6584f;
        float eurTuUsd = 1.0582f;
        int sumToExchange;
        string userChoice;
        Console.WriteLine($"Добрый день, на вашем счету {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
        Console.WriteLine("У нас вы можете обменять ваши деньги по выгодному курсу.");
        Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");

        while (Console.ReadLine() != "C")
        {
            Console.WriteLine("Рубли в доллары - 1, рубли в евро - 2, доллары в рубли - 3, доллары в евро - 4, евро в рубли - 5, евро в доллары - 6");
            userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Сколько рублей в доллары вы хотите обменять?");
                    sumToExchange = Convert.ToInt32(Console.ReadLine());

                    if (sumToExchange > balanceRUB)
                    {
                        Console.WriteLine("у вас недостаточно рублей");
                    }
                    else
                    {
                        balanceRUB -= sumToExchange;
                        balanceUSD += sumToExchange * rubToUsd;
                    }
                    Console.WriteLine($"Ваш баланс {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");
                    break;

                case "2":
                    Console.WriteLine("Сколько рублей в евро вы хотите обменять?");
                    sumToExchange = Convert.ToInt32(Console.ReadLine());

                    if (sumToExchange > balanceRUB)
                    {
                        Console.WriteLine("у вас недостаточно рублей");
                    }
                    else
                    {
                        balanceRUB -= sumToExchange;
                        balanceEUR += sumToExchange * rubToEur;
                    }
                    Console.WriteLine($"Ваш баланс {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");
                    break;

                case "3":
                    Console.WriteLine("Сколько долларов в рубли вы хотите обменять?");
                    sumToExchange = Convert.ToInt32(Console.ReadLine());

                    if (sumToExchange > balanceUSD)
                    {
                        Console.WriteLine("у вас недостаточно долларов");
                    }
                    else
                    {
                        balanceUSD -= sumToExchange;
                        balanceRUB += sumToExchange * usdToRub;
                    }
                    Console.WriteLine($"Ваш баланс {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");
                    break;

                case "4":
                    Console.WriteLine("Сколько долларов в евро вы хотите обменять?");
                    sumToExchange = Convert.ToInt32(Console.ReadLine());

                    if (sumToExchange > balanceUSD)
                    {
                        Console.WriteLine("у вас недостаточно долларов");
                    }
                    else
                    {
                        balanceUSD -= sumToExchange;
                        balanceEUR += sumToExchange * usdToEur;
                    }
                    Console.WriteLine($"Ваш баланс {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");
                    break;

                case "5":
                    Console.WriteLine("Сколько евро в рубли вы хотите обменять?");
                    sumToExchange = Convert.ToInt32(Console.ReadLine());

                    if (sumToExchange > balanceEUR)
                    {
                        Console.WriteLine("у вас недостаточно евро");
                    }
                    else
                    {
                        balanceEUR -= sumToExchange;
                        balanceRUB += sumToExchange * eurToRub;
                    }
                    Console.WriteLine($"Ваш баланс {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");
                    break;

                case "6":
                    Console.WriteLine("Сколько евро в доллары вы хотите обменять?");
                    sumToExchange = Convert.ToInt32(Console.ReadLine());

                    if (sumToExchange > balanceEUR)
                    {
                        Console.WriteLine("у вас недостаточно евро");
                    }
                    else
                    {
                        balanceEUR -= sumToExchange;
                        balanceUSD += sumToExchange * eurTuUsd;
                    }
                    Console.WriteLine($"Ваш баланс {balanceRUB} рублей, {balanceUSD} долларов, {balanceEUR} евро");
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения работы - нажмите С");
                    break;
            }
        }
    }
}