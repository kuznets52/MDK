using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя номер месяца
        Console.Write("Введите номер месяца (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        // Проверяем корректность ввода месяца
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Некорректный месяц. Пожалуйста, введите число от 1 до 12.");
            return;
        }

        // Определяем количество дней в месяце
        int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, month);
        double[] precipitation = new double[daysInMonth];
        Random rand = new Random();

        // Заполняем массив случайными значениями осадков
        for (int i = 0; i < daysInMonth; i++)
        {
            precipitation[i] = rand.NextDouble() * 100; // Случайные значения от 0 до 100 мм
        }

        // Вычисляем общее количество осадков на четные дни
        double totalEvenDaysPrecipitation = 0;

        // Проходим по массиву: четные дни (2, 4, 6... - т.е. индексы 1, 3, 5... в 0-индексированном массиве)
        for (int i = 1; i < daysInMonth; i += 2) // Индексы четных дней
        {
            totalEvenDaysPrecipitation += precipitation[i]; // Суммируем осадки для четных дней
        }

        // Выводим результаты
        Console.WriteLine($"Общее количество осадков на четные дни месяца {month}: {totalEvenDaysPrecipitation:F2} мм");
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем размер массива
        Console.Write("Введите количество элементов в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n <= 0)
        {
            Console.WriteLine("Количество элементов должно быть больше 0.");
            return;
        }

        int[] array = new int[n];
        
        // Запрашиваем элементы массива
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Находим индекс первого минимального элемента
        int minIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        // Выводим количество элементов перед первым минимальным элементом
        Console.WriteLine($"Количество элементов перед первым минимальным элементом: {minIndex}");
    }
}



using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine(); // Ввод строки
        string[] words = input.Split(new char[] { '_', ' ' }, StringSplitOptions.RemoveEmptyEntries); // Разделяем строку на слова

        int consonantCount = 0; // Счетчик согласных букв
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ"; // Все согласные буквы

        foreach (var word in words)
        {
            foreach (char letter in word)
            {
                if (consonants.Contains(letter)) // Проверяем, является ли буква согласной
                {
                    consonantCount++;
                }
            }
        }

        Console.WriteLine(consonantCount); // Выводим количество согласных букв
    }
}







