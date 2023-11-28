    int[] numbers = new int[9];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Введите число: ");
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                i--;
            }
            else
            {
                numbers[i] = input;
            }
        }

        int sum = 0;
        Console.WriteLine("Исходный массив чисел:");
        PrintArray(numbers);
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 3 == 0)
            {
                sum += numbers[i];
            }
        }
        Console.WriteLine("Сумма всех чисел, кратных 3: " + sum);

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

