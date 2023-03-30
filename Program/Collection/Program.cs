using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 콜렉션(Queue)
            //Queue queue = new Queue();
            //
            //Enqueue : 데이터를 저장하는 멤버 함수
            //queue.Enqueue(10);     // [10]
            //queue.Enqueue("Game"); // [10] [Game]
            //
            //Console.WriteLine("queue의 사이즈 : " + queue.Count);
            //Console.WriteLine(queue.Dequeue()); // [Gmae]
            //
            //Console.WriteLine("queue의 사이즈 : " + queue.Count);
            //Console.WriteLine(queue.Dequeue()); // empty
            #endregion

            #region 콜렉션 일반화 (Queue)
            //Queue<int> genericQueue = new Queue<int>();
            //
            //genericQueue.Enqueue(99);  // [99]
            //genericQueue.Enqueue(100); // [99] [100]
            //genericQueue.Enqueue(111); // [99] [100] [111]
            //
            //// Peek( ) : 맨 앞에 있는 원소를 출력하는 함수
            //Console.WriteLine(genericQueue.Peek());
            //
            //genericQueue.Clear(); // empty
            //
            // genericQueue.Dequeue();
            #endregion

            #region 콜렉션 일반화 (Stack)
            //Stack<string> stack = new Stack<string>();
            //
            //stack.Push("Earth"); // [Earth]
            //stack.Push("Sun");   // [Sun] [Earth]
            //stack.Push("Moon");  // [Moon] [Sun] [Earth]
            //
            //// Contains( ) : 특정 값이 존재하는 지 확인하는 함수
            //Console.WriteLine(stack.Contains("Mars"));
            //
            //Console.WriteLine(stack.Pop()); // [Sun] [Earth]
            //Console.WriteLine(stack.Pop()); // [Earth]
            //Console.WriteLine(stack.Pop()); // empty
            #endregion

            # region 콜렉션 일반화 (List)
            List<float> list = new List<float>();

            // Add() : 데이터를 추가하는 하는 함수
            list.Add(10.5f);
            list.Add(20.25f);
            list.Add(30.35f);
            list.Add(40.75f);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // Remove() : 특정한 원소 또는 값을 삭제하는 함수
            list.Remove(list[0]);
            Console.WriteLine(list[0]);

            // Insert( , ) : 특정한 인덱스에 원하는 데이터를 추가하는 함수
            list.Insert(2, 63.825f);
            Console.WriteLine(list[2]);

            #endregion
        }
    }
}