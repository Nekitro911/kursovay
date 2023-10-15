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
            //int[] numbers = new int[10];
            List<int> numbers = new List<int>();
            int count; // Счетчик числа введенных чисел
            string input = Console.ReadLine(); // Ввод строки чисел

            while (input != "")
            {
                // Разбиение строки на отдельные числа
                string[] numberStrings = input.Split();

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    numbers.Add(int.Parse(numberStrings[i]));
                    //numbers[count] = int.Parse(numberStrings[i]);
                    //count++;
                }

                input = Console.ReadLine();
            }

            // Console.WriteLine($"Введено {count} чисел.");
            Console.WriteLine($"Введено {numbers.Count} чисел.");
            numbers.Sort();
            
            Console.WriteLine("Введите числа через пробел или Enter для завершения ввода:");

            while (input != "")
            {
                // Разбиение строки на отдельные числа
                string[] numberStrings = input.Split();

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    numbers.Add(int.Parse(numberStrings[i]));
                    //numbers[numbers.Count] = int.Parse(numberStrings[i]);
                    //count++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Введено {numbers.Count} чисел.");

            numbers.Sort();

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
                randomArray[i] = random.Next(1,500);
            }
            Console.WriteLine($"Случайный массив:");
            Console.WriteLine($"Выведено {range} чисел:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }

            Array.Sort(randomArray);
            Console.WriteLine($"\nОтсортированные числа:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}
