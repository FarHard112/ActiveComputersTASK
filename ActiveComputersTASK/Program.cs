using ActiveComputersTASK.Models;
using System;
using static ActiveComputersTASK.Models.LinkedList;

namespace ActiveComputersTASK
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Реализовать приложение C#, которое предоставит
            //    функционал сложения каждого второго нечетного 
            //    числа из массива чисел тела запроса и вернёт 
            //    их сумму по модулю.
            //Console.WriteLine(Ex1(new int[] { 2, -3, 4, -7, 10, -11, 112, -15, 16, -19 }));

            //2.2. Реализовать приложение C#, которое предоставит функционал сложения двух непустых связанных списков
            //, представляющих два положительных целых числа. Цифры хранятся в обратном порядке, каждый из их узлов
            //содержит одну цифру.Реализуйте алгоритм сложения связанных списков,
            //    не переводя хранящиеся в них данные в числовой тип(по - узловое сложение), 
            //    возвращающий результат в виде связанного списка.

            //EX2 

            LinkedList list = new LinkedList();

            // Первый лист
            list.head1 = new Node(7);
            list.head1.next = new Node(5);
            list.head1.next.next = new Node(9);
            list.head1.next.next.next = new Node(4);
            list.head1.next.next.next.next = new Node(6);
            Console.Write("первый");
            list.printList(list.head1);
            // Второй лист
            list.head2 = new Node(8);
            list.head2.next = new Node(4);
            Console.Write("Второй");
            list.printList(list.head2);
            //Резултать
            Node rs = list.addTwoLists(list.head1, list.head2);
            Console.Write("Лист1 + лист 2");
            list.printList(rs);


            //Ex3

            //3. Реализовать приложение C#,
            //которое предоставит функционал определения
            //входящий строки является ли она палиндромом.

            //Console.WriteLine(IsPalindrom("yaya"));

            Console.ReadKey(true);

        }

        //Ex1
        //public static int Ex1(int[] n)
        //{
        //    List<int> oddList = new List<int>();
        //    int sum = 0;
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        if (n[i] % 2 == 0)
        //        {
        //            continue;
        //        }
        //        oddList.Add(n[i]);
        //    }
        //    sum = oddList.Where((x, i) => i % 2 != 0).Sum();
        //    return sum;
        //}

        //Ex2




        //Ex3 

        //private static bool IsPalindrom(string str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //        if (str[i] != str[str.Length - i - 1]) return false;
        //    return true;
        //}





    }
}
