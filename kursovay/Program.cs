using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovay
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool SetConsoleOutputCP(uint wCodePageID);

        [DllImport("kernel32.dll")]
        public static extern bool SetConsoleCP(uint wCodePageID);
        static void Main(string[] args)
        {
            SetConsoleOutputCP(1251);
            SetConsoleCP(1251);
            Console.SetWindowSize(80, 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Сортировка";
            char c;
            while (true)
            {              
                Console.WriteLine(" :");
                Console.WriteLine(" 1 - Создание рандомного массива:");
                Console.WriteLine(" 2 - Ввод данных с клавиатуры:");         
                Console.WriteLine(" Esc - Выход");
                c = Console.ReadKey().KeyChar;
                switch (c)
                {
                    case '1':
                        //Console.Clear();
                        //NameSort(IndexArray);
                        RandomMassive();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        Console.Clear();
                        //LocationSort(IndexArray);
                        VvodUsers();
                        Console.ReadKey();
                        Console.Clear();
                        break;                  
                    case (char)27:
                        return;
                    default:
                        Console.WriteLine("\n Ошибка!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }            
        }
        static void VvodUsers()
        {
            Console.WriteLine("Введите числа через пробел или Enter для завершения ввода:");          
            List<int> numbers = new List<int>();//Список для введеных чисел
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
            Console.WriteLine($"Введено {numbers.Count} чисел.");           
            numbers.Sort();
            Console.WriteLine($"Отсортированные числа в порядке возрастания:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            numbers.Reverse();
            Console.WriteLine($"\nОтсортированные числа в порядке убывания:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nEsc - Выход");
        }
        static void RandomMassive()
        {
            Console.Write("\nВведите диапазон чисел (например, 5) для создания случайного массива:  ");
            int range = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] randomArray = new int[range];
            for (int i = 0; i < range; i++)
            {
                randomArray[i] = random.Next(1,500);
            }
            Console.WriteLine($"Случайный массив:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }
            Array.Sort(randomArray);
            Console.WriteLine($"\nОтсортированные числа в порядке возрастания:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }
            Array.Reverse(randomArray);
            Console.WriteLine($"\nОтсортированные числа в порядке убывания:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nEsc - Выход");
        }
    }
}
