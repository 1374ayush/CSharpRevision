using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp.Test
{
    internal class dsa
    {
        public void method()
        {
            //1-D array
            /* int[] arr = { 1, 2, 345, 5, 65, 4 };
             Array.Sort(arr);

             //2d array
             int[,] arr1 = new int[2, 3];
             int[,] arr2 = { { 31, 3 }, { 1, 4 } };*/
            /*
                        Array.Sort(arr2);
            */
            /*       for(int i=0; i<arr2.Length; i++)
                   {
                       for(int j=0; j<2; j++)
                       {
                           Console.WriteLine(arr2[i,j]);
                           arr2[i,j] = 0;
                       }
            }*/

            //jagged array
            /*            int[][] arr3 = new int[3][];
                        arr3[0] = new int[] { 1 ,3 ,4 ,2 };
                        arr3[1] = new int[] { 1, 3, 4, 2 };
                        arr3[2] = new int[] { 1, 3, 4, 2 };

                        for (int i=0; i<arr3.Length; i++)
                        {
                            Array.Sort(arr3[i]);
                            for(int j=0; j < arr3[i].Length; j++)
                            {
                                Console.Write(arr3[i][j] + " ");
                                arr3[i][j] = 0;
                            }

                            Console.WriteLine();
                        }
            */

            List<string> list = new List<string>() { "Ayush", "Piyush", "Sweety", "Sanjay" };

            list[0] = "Ayush Srivastava";

            list.Add("Srivastavas");
            list.Sort();
            list.Remove("Ayush Srivastava");

            /* foreach (var i in list)
             {
                 Console.WriteLine(i);
             }*/

            /* Console.WriteLine(list.Count);*/

            /* List<List<int>> ints = new List<List<int>>();

             ints.Add(new List<int>() { 1,2,3,45,5,6});
             ints.Add(new List<int>() { 1,2,3,4,5,6});

             foreach(var ele in  ints)
             {
                 foreach(var i in ele)
                 {
                     Console.Write(i + " ");
                 }
                 Console.WriteLine();    
             }*/

            /*            Stack<string> stack = new Stack<string>(list);
                        Stack<int> st = new Stack<int>();

                        st.Push(1);
                        st.Push(2);

                        while(stack.Count > 0)
                        {
                            Console.WriteLine(stack.Peek());
                            Console.WriteLine(stack.Pop());
                        }*/
            /*
                        Queue<int> que = new Queue<int>();
                        que.Enqueue(1);
                        que.Enqueue(2);

                        Console.WriteLine( que.Peek());

                        while( que.Count > 0)
                        {
                            Console.WriteLine( que.Dequeue() );
                        }*/
            /*
                        Dictionary<int, int> dict = new Dictionary<int, int>();
                        dict.Add(21, 2);
                        dict.Add(2, 3);

                        dict[10] = 11;

                        foreach(var ele in dict)
                        {
                            Console.Write(ele.Key + ": " + ele.Value);
                        }

                        dict.Remove(1);
                        Console.WriteLine(dict.Count);

                        dict.Clear();
            */
            /*
                        Hashtable ht = new Hashtable();
                        ht.Add(1, 2);
                        ht.Add(2, "Hello");

                        foreach(DictionaryEntry ele in ht)
                        {
                            int key = (int)ele.Key;
                            Console.WriteLine(key);
                        }*/

            /*      ArrayList newLis = new ArrayList();
                  newLis.Add(10);
                  newLis.Add("hello");

                  foreach(var ele in newLis)
                  {
                      Console.WriteLine(ele);
                  }
      */

            /*  StringBuilder sb = new StringBuilder("Hello ji");
               sb.Append(" namaste");
               sb.AppendLine("My self Ayush");

               Console.WriteLine(sb.ToString());*/

            //Linked List implementation in C# using class

          /*  Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);

            Node temp = head;

            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }*/

            
        }
    }

    public class Node
    {
        public int data { get ; set;}
        public Node next { get; set;}

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
