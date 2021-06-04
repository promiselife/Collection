using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace DataStructre
{
    class Program
    {
        public static long TestStack(IStack<int> stack,int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);
            for (int i = 0; i < N; i++)
                stack.Pop();
            t.Stop();

            return t.ElapsedMilliseconds;

        }

        static void Main(string[] args)
        {
            ////静态数组
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = i;
            //}

            ////动态数组
            //ArrayList a = new ArrayList(10);
            //for (int i = 0; i < 10; i++)
            //{
            //    a.Add(i);
            //}

            //List<int> l = new List<int>(10);
            //for (int i = 0; i < 10; i++)
            //{
            //    l.Add(i);
            //}

            //Array1 a1 = new Array1(20);
            //for (int i = 0; i < 10; i++)
            //{
            //    a1.AddFirst(i);
            //}
            //Console.WriteLine(a1);
            //a1.AddFirst(66);
            //Console.WriteLine(a1);  
            //a1.Add(2,11);
            //Console.WriteLine(a1);
            //Console.WriteLine(a1.GetFirst());
            //Console.WriteLine(a1.GetLast());
            //Console.WriteLine(a1.Get(1));
            //a1.Set(1, 1000);
            //Console.WriteLine(a1);
            //a1.RemoveAt(2);
            //a1.RemoveFirst();
            //a1.RemoveLast();
            //Console.WriteLine(a1);


            /*
            int n = 10000000;
            Console.WriteLine("测试值类型int");
            Stopwatch t1 = new Stopwatch();
            Stopwatch t2 = new Stopwatch();
            Stopwatch t3 = new Stopwatch();
            Stopwatch t4 = new Stopwatch();
            //明显可以看到  在存储值类型中  ArryList使用的时间是List几乎10倍
            t1.Start();
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++)
            {
                l.Add(i);
                int x = l[i];
            }
            t1.Stop();
            Console.WriteLine("List 'time:' "+t1.ElapsedMilliseconds+"ms");
            t2.Start();
            ArrayList a = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                a.Add(i);    //发生装箱   
                int x = (int)a[i];//发生拆箱   
            }
            t2.Stop();
            Console.WriteLine("ArrayList 'time:' " + t2.ElapsedMilliseconds + "ms");
            //明显可以看到  在存储引用类型中  ArryList使用的时间比List少，但是差异并不明显
            Console.WriteLine("测试引用类型类型string");
            t3.Start();
            List<string> l2 = new List<string>();
            for (int i = 0; i < n; i++)
            {
                l2.Add("X");
                string x = l2[i];
            }
            t3.Stop();
            Console.WriteLine("List 'time:' " + t3.ElapsedMilliseconds + "ms");
            t4.Start();
            ArrayList a2 = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                a2.Add("X");     //不发生装箱         
                string x = (string)a2[i];//不发生拆箱        
            }
            t4.Stop();
            Console.WriteLine("ArrayList 'time:' " + t4.ElapsedMilliseconds + "ms");
            */


            /*
            int[] n = { 1, 2, 3, 4, 5, 6, 7 };
            ArrayGeneric<int> a = new ArrayGeneric<int>();
            for (int i = 0; i < n.Length; i++)
            {
                a.AddLast(n[i]);
            }
            Console.WriteLine(a);

            string[] s = { "a", "b", "c" };
            ArrayGeneric<string> a2 = new ArrayGeneric<string>();
            for (int i = 0; i < s.Length; i++)
            {
                a2.AddLast(s[i]);
            }
            Console.WriteLine(a2);
            */


            /*  数组栈
            Array1Stack<int> stack = new Array1Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack);
            }
            stack.Pop();
            Console.WriteLine(stack);
            */

            /*链表栈
            LinkedList1Stack<int> stack = new LinkedList1Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack);
            }
            stack.Pop();
            Console.WriteLine(stack);

            int N = 20000000;
            Array1Stack<int> array1Stack = new Array1Stack<int>(N);
            long t1 = TestStack(array1Stack, N);
            Console.WriteLine("Array1Stack time : " + t1 + "ms");

            LinkedList1Stack<int> linkedList1Stack = new LinkedList1Stack<int>();
            long t2 =  TestStack(linkedList1Stack, N);
            Console.WriteLine("linkedList1Stack time : " + t2 + "ms");
            */

            //数组队列
            Array1Queue<int> array1Queue = new Array1Queue<int>();
            for (int i = 0; i < 5; i++)
            {
                array1Queue.Enqueue(i);
                Console.WriteLine(array1Queue);
            }
            array1Queue.Dequeue();


            Console.Read();
        }
    }
}
