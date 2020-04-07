/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyDictionary<TKey,TValue>. 
Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5). 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов.  
*/
using System;
using System.ComponentModel;

namespace Task3
{
    class MyDictionary<Tkey, TValue>
    {
        public void AddElements()
        {

        }
    }

    class Program
    {
        static string twoWordsWithASpacebar;
        static string[] arrayOfWordsWithoutSpacebar;
        static MyDictionary<string, string> dictionary;

        static void Main(string[] args)
        {
            Console.WriteLine("Пример новых комбинаций для словаря:\napple яблоко orange апельсин");

            Console.ForegroundColor = ConsoleColor.Green;
            twoWordsWithASpacebar = Console.ReadLine();
            Console.ResetColor();

            if (twoWordsWithASpacebar.Contains(' '))
            {
                arrayOfWordsWithoutSpacebar = twoWordsWithASpacebar.Split(' ');
                dictionary = new MyDictionary<string, string>();
            }

            else
                Console.WriteLine("Строка не содержит пробела.");



            //Console.WriteLine(dictionary["солнце"]);
            //Console.WriteLine(dictionary["ручка"]);
            //Console.WriteLine(dictionary["book"]);
            //Console.WriteLine(dictionary["sun"]);
            //Console.WriteLine(dictionary["стiл"]);
            //Console.WriteLine(dictionary["олівець"]);
            //Console.WriteLine(dictionary["яблуко"]);

            Console.WriteLine("\n" + new string('-', 30) + "\n");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(dictionary[i]);
            //}
        }
    }
}
