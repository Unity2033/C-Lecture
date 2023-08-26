namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for 문
            // 초기식을 연산하여 조건식의 결과에 따라
            // 특정한 횟수만큼 반복하는 반복문입니다.

            // for(int i = 1; i <= 5; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for문의 경우 조건이 끝나는 형태와 반대로
            // 초기식을 연산하게 되면 조건이 일치하지 않아
            // 계속 반복적으로 실행되는 문제가 발생합니다.

            #endregion

            #region while 문
            // 특정 조건을 만족할 때까지 계속해서
            // 주어진 명령문을 실행하는 반복문입니다.

            // int count = 5;
            // 
            // while(count > 0)
            // {
            //     Console.WriteLine("Cat");
            //     count--;
            // }
            #endregion

            #region Console Key 입력

            //int x = 5;
            //int y = 5;

            //ConsoleKeyInfo consoleKey;

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("☆");

            //    consoleKey = Console.ReadKey(true);

            //    switch (consoleKey.Key)
            //    {
            //        case ConsoleKey.LeftArrow :
            //            if (x > 0)
            //            {
            //                x--;
            //            }
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x++;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            if (y > 0)
            //            {
            //                y--;
            //            }
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;
            //    }
            //}
            #endregion

            #region switch 문
            // 어떤 결과에 따라 그 결과부터 실행되는 명령문입니다.

            //int key = 2;

            //switch(key)
            //{
            //    case 0 : Console.WriteLine("Zero");
            //        break;
            //    case 1 : Console.WriteLine("One");
            //        break;
            //    default : Console.WriteLine("?");
            //        break;
            //}
            #endregion

            #region if 문
            // 어떤 특정한 조건을 비교하여 조건이 맞다면
            // 실행되는 명령문입니다.

            //int health = 0;

            //if(health <= 0)
            //{
            //    Console.WriteLine("게임이 종료되었습니다.");
            //}

            #endregion

            #region else 문
            // if 문과 else if 문의 조건이 다 틀리면 실행되는
            // 명령문입니다.

            int age = 20;

            if(age > 100)
            {
                Console.WriteLine("if문의 조건");
            }
            else if(age > 50)
            {
                Console.WriteLine("else if문의 조건");
            }
            else
            {
                Console.WriteLine("else 문의 조건");
            }

            #endregion

            #region Random 함수

            //Random random = new Random();

            //int life = 3;
            //int computer = random.Next(0, 11);
            //int answer = 0;

            //while (life > 0)
            //{
            //    Console.Write("컴퓨터가 가지고 있는 값 : ");

            //    answer = int.Parse(Console.ReadLine());

            //    if(answer == computer)
            //    {
            //        Console.WriteLine("게임에서 승리하였습니다~");
            //        break;
            //    }
            //    else if(answer < computer)
            //    {
            //        Console.WriteLine("컴퓨터가 가지고 있는 값보다 작습니다.");
            //        life--;
            //    }
            //    else if(answer > computer)
            //    {
            //        Console.WriteLine("컴퓨터가 가지고 있는 값보다 큽니다.");
            //        life--;
            //    }

            //    Console.WriteLine(" ");
            //    Console.WriteLine("--------------------------------------");
            //    Console.WriteLine(" ");
            //}

            //if(life <= 0)
            //{
            //    Console.WriteLine("게임에서 패배하였습니다~");
            //}

            #endregion

        }
    }
}