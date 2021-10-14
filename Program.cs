using System;
using System.Collections.Generic;
using System.Collections;

namespace Demo_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Ferari = new Car();
           
            Console.WriteLine("Welcome to the Implemetnation of Collection in C#");


            //Step1 : Crating Object of the Class (Defining Collection)
            //Step2 : Adding Elelement in side Collection 
            //Step3 : Displaying Element in Collections 

            //var MYLIST = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Strongly typed List 

            //foreach (var item in MYLIST)
            //{
            //    Console.WriteLine(item);
            //}

            //var MyCars = new List<string> { "TESLA", "Porsche", "BMW" };
            //foreach (var item in MyCars)
            //{
            //    Console.WriteLine(item);
            //}

            ////for (int i = 0; i < MyCars.Count; i++)
            ////{
            ////    Console.WriteLine("Car name is {0 }", MyCars[i]);
            ////    //String Interpolation
            ////}


            //Stack<string> Numbers = new Stack<string>();
            //Numbers.Push("One");
            //Numbers.Push("Two");
            //Numbers.Push("Three");

            ////Display all Contents Of Stack

            //foreach (var item in Numbers)

            //{
            //    Console.WriteLine("Following are the Contents of Collection\t {0}\n",item);
            //}

            ////Remove an Element from Stack 

            //Console.WriteLine("Removing top of my Stack \n {0}", Numbers.Pop());

            //Queue<int> MyQue = new Queue<int>();

            //MyQue.Enqueue(120);
            //MyQue.Enqueue(190);
            //MyQue.Enqueue(250);

            //foreach (var item in MyQue)
            //{
            //    Console.WriteLine("Elemts of My Queue is {0}", item);
            //}

            //Removing element from Queue 

            //Console.WriteLine("First element that is Removed from the Que is {0}", MyQue.Dequeue());

            //Console.WriteLine("Total Count of the Queue is {0}", MyQue.Count);
            //Console.WriteLine("Type of the Queue is {0}", MyQue.GetType());

            //ArrayList MyArrayList = new ArrayList();
            //MyArrayList.Add(24);
            //MyArrayList.Add("Tom Cruise");
            //MyArrayList.Add(24.34567);
            //MyArrayList.Add(true);
            //MyArrayList.Add("DivideByZeroException");
            //foreach (var item in MyArrayList)
            //{

            //    Console.WriteLine("Content of My Array List whivh is non-genric type of Collection {0}\n", item);
            //}

            //SortedList<string,int> GameScore = new SortedList<string,int>();
            //GameScore.Add("My COD Score was" ,1299);
            //GameScore.Add("Last Week NFS Score was", 1250);
            //GameScore.Add("FIFA Score is", 111);

            //foreach (var item in GameScore)
            //{
            //    Console.WriteLine("Content of game Score Collection is \t{0} and value \t{1}\n", item.Key, item.Value);
            //}

            //Dictionary<string, string> PasswordDetails = new Dictionary<string, string>();
            //PasswordDetails.Add("Facebook", "@#$%^&");
            //PasswordDetails.Add("InstaGram", "*&^%");
            //PasswordDetails.Add("Outlook.com", "QWERTY");


            //foreach (var item in PasswordDetails)
            //{
            //    Console.WriteLine("Content of the Dictionary with \t Key is: {0}, Value is \t{1}",item.Key,item.Value);

            //}
            //Console.WriteLine("total Count of the Element{0}", PasswordDetails.Count);

            Hashtable MyHashTable = new Hashtable();
            MyHashTable.Add(01,"Delhi");
            MyHashTable.Add(02, "Mumbai");
            MyHashTable.Add(03, "Chennai");

            Console.WriteLine("Total Content of thehashtable is {0}",MyHashTable.Count);

            foreach (DictionaryEntry item in MyHashTable)
            {
                Console.WriteLine("Hash Code of the element is {0}\n", item.GetHashCode());
                Console.WriteLine("Content of the table is \t Key: {0} and Value:{1}\n",item.Key, item.Value);
            }






        }

       


       





    }

}
