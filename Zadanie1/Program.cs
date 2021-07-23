using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie1
{
    class Program
    {
        

        enum Operation
        {
            First = 1,
            Second = 2,
            Third = 3,
            Exit = 0
        }

        static void Main(string[] args)
        {
            int sizeRand = 100;
            int sizeArr = 10;
            int select = 1;
            Operation operation = (Operation)select;


            int[] mass = new int[sizeArr];

            Random rand = new Random();

            

            

            while (operation != Operation.Exit)
            {
                Console.Write("Текущий массив: ");
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rand.Next(sizeRand);

                    Console.Write("{0} ", mass[i]);
                }

                Console.WriteLine("\n1. Задание 1");
                Console.WriteLine("2. Задание 2");
                Console.WriteLine("3. Задание 3");
                Console.WriteLine("0. Выход");

                Console.WriteLine("\nВыберите дейсвие: ");
                select = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                operation = (Operation)select;
                

                SelectionOperation(operation, mass);
                Console.ReadKey();
                Console.Clear();

            }
        }
        
        static void SelectionOperation(Operation operation, int[] mass)
        {
            switch(operation)
            {
                case Operation.First:
                    SortFirst(mass);
                    break;

                case Operation.Second:
                    SortSecond(mass);
                    break;

                case Operation.Third:
                    SortThird(mass);
                    break;

                case Operation.Exit: 
                    Console.Clear(); 
                    Console.WriteLine("Досвидание!"); 
                    break;

                default:
                    Console.WriteLine("Неккоректный ввод!");
                    break;
            }
        }

        private static void SortThird(int[] mass)
        {
            int[] newArray = new int[mass.Length];

            int temp;

            for (int i = 0; i < mass.Length; i++)
            {
                newArray[i] = mass[i];
            }


            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = i+1; j < newArray.Length; j++)
                {
                    if (newArray[i] % 2 != 0 && newArray[j] % 2 == 0)
                    {
                        temp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = temp;
                    }
                }
            }

            for (int i = 0; i < newArray.Length-1; i++)
            {
                for (int j = i + 1; j < newArray.Length; j++)
                {
                    if (newArray[i] < newArray[j] && newArray[j] % 2 == 0)
                    {
                        temp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = temp;
                    }

                    if(newArray[i] > newArray[j] && newArray[j] % 2 != 0)
                    {
                        temp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = temp;
                    }
                }
            }



            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }

        }

        private static void SortSecond(int[] mass)
        {
            int[] newArray = new int[mass.Length];
            int temp;

            for (int i = 0; i < mass.Length; i++)
            {
                newArray[i] = mass[i];
            }

            RemoveAtNechet(ref newArray);

            
            for (int i = 0; i < newArray.Length/2; i++)
            {
                temp = newArray[newArray.Length - i - 1];
                newArray[newArray.Length - i - 1] = newArray[i];
                newArray[i] = temp;
            }

            Console.WriteLine("\nНовый массив: ");
            for (int i = 0; i < newArray.Length; i++)
                Console.Write(newArray[i]+ " ");

        }

        private static void RemoveAtNechet(ref int[] array)
        {
            List<int> newArr = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    newArr.Add(array[i]);
            }

            array = newArr.ToArray();
        }

        private static void SortFirst(int[] mass)
        {
            int[] newArray = new int[mass.Length];
            int temp;

            for (int i = 0; i < mass.Length; i++)
            {
                newArray[i] = mass[i];
            }



            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = i + 1; j < newArray.Length; j++)
                {
                    if (newArray[i] > newArray[j])
                    {
                        temp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = temp;
                    }
                }
            }

            RemoveAtChet(ref newArray);


            Console.Write("\nНовый массив: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]+" ");
            }
        }

        static void RemoveAtChet(ref int[] array)
        {
            List<int> newArr = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    newArr.Add(array[i]);
            }

            array = newArr.ToArray();
        }
    }
}
