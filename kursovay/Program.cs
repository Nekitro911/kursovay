using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovay
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Выберете метод входа данных: ");
            Console.WriteLine("1 - Создание рандомного массива: ");
            Console.WriteLine("2 - Ввод данных с клавиатуры: ");
            string input = Console.ReadLine(); // Ввод строки чисел

            if (input == "1")
            {
                RandomMassive();
            }
            else if (input == "2")
            {
                VvodUsers();
            }
        }
        static void VvodUsers()
        {
            Console.WriteLine("Введите числа через пробел или Enter для завершения ввода:");


            // Массив для хранения входных чисел
            int[] numbers = new int[10];

            int count = 0; // Счетчик числа введенных чисел
            string input = Console.ReadLine(); // Ввод строки чисел

            while (input != "")
            {
                // Разбиение строки на отдельные числа
                string[] numberStrings = input.Split();

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    numbers[count] = int.Parse(numberStrings[i]);
                    count++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Введено {count} чисел.");

            Array.Sort(numbers, 0, count);

            Console.WriteLine("Введите числа через пробел или Enter для завершения ввода:");

            while (input != "")
            {
                // Разбиение строки на отдельные числа
                string[] numberStrings = input.Split();

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    numbers[count] = int.Parse(numberStrings[i]);
                    count++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Введено {count} чисел.");

            Array.Sort(numbers, 0, count);

            Console.WriteLine($"Отсортированные числа:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
        static void RandomMassive()
        {
            Console.WriteLine("Введите диапазон чисел (например, 5) для создания случайного массива:");
            int range = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] randomArray = new int[range];
            for (int i = 0; i < range; i++)
            {
                randomArray[i] = random.Next();
            }

            Array.Sort(randomArray);

            Console.WriteLine($"Случайный массив:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }
}
