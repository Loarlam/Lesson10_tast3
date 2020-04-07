/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyDictionary<TKey,TValue>. 
Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary (Урок 6 пример 5). 
Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, 
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов.  
*/
using System;

namespace Task3
{
    class MyDictionary<Tkey, TValue>
    {
        string[] _arrayOfKeysAndValues;
        int _pairCounter;

        //Индексатор типа string для получения значеня пар слов по указанному индексу типа string
        //В цикле for ищется включение слова в элементах массива
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _arrayOfKeysAndValues.Length; i++)
                {
                    if (_arrayOfKeysAndValues[i].Contains(index))
                    {
                        return _arrayOfKeysAndValues[i];
                    }                    
                }
                return $"{index} - нет перевода для этого слова.";
            }
        }

        //MyDictionary - конструктор по умолчанию, в котором задаётся размерность массива _arrayOfKeysAndValues
        public MyDictionary(int arraySize)
        {
            _arrayOfKeysAndValues = new string[arraySize];
        }

        //TotalNumberOfElementPairs - свойство, выдающее общее количество пар элементов слов
        public int TotalNumberOfElementPairs => _pairCounter;

        //AddParisOfElements - метод добавляет пары слов в массив __arrayOfKeysAndValues
        public void AddPairsOfElements(Tkey keyEngWord, TValue keyRusValue)
        {
            _arrayOfKeysAndValues[_pairCounter] = keyEngWord + " - " + keyRusValue;
            _pairCounter++;
        }
    }

    class Program
    {
        static string twoWordsWithASpacebar, theRequestWord;
        static string[] arrayOfWordsWithoutSpacebar;
        static MyDictionary<string, string> dictionary;

        static void Main()
        {
            Console.WriteLine("Пример новых комбинаций для словаря:\napple яблоко orange апельсин\n\nЗапись новых слов: ");

            Console.ForegroundColor = ConsoleColor.Green;
            twoWordsWithASpacebar = Console.ReadLine();
            Console.ResetColor();

            //Имеется ли в строке спецсимвол пробел? Если да, то разбиваем строку на подстроки и передаём в метод AddPairsOfElements английское и русское слово
            if (twoWordsWithASpacebar.Contains(' ') && (twoWordsWithASpacebar[twoWordsWithASpacebar.Length-1] != ' '))
            {
                arrayOfWordsWithoutSpacebar = twoWordsWithASpacebar.Split(' ');
                dictionary = new MyDictionary<string, string>(arrayOfWordsWithoutSpacebar.Length/2);

                for (int i = 0; i < arrayOfWordsWithoutSpacebar.Length; i++)
                {
                    dictionary.AddPairsOfElements(arrayOfWordsWithoutSpacebar[i], arrayOfWordsWithoutSpacebar[i+1]);
                    i++;
                }

                Console.WriteLine("\nПеревод какого слова вывести на экран?");
                Console.ForegroundColor = ConsoleColor.Green;
                theRequestWord = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine($"\n{dictionary[theRequestWord]}");
            }

            else
                Console.WriteLine("\nСтрока либо не имеет пробела между словами, либо заканчивается пробелом!");            

            Console.ReadKey();
        }
    }
}
