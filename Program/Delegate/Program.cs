using System.Diagnostics;

namespace Delegate
{
    delegate void Delegate();

    class Player
    {
       public void Damage(Enemy enemy)
       {
            Delegate callback = State;
            enemy.Attack(callback);
       }

       public void State()
       {
            Console.WriteLine("공격을 당했습니다.");
       }
    }

    class Enemy
    {
        public void Attack(Delegate callback)
        {
            Console.WriteLine("공격");

            callback(); // 공격을 당했습니다.
        }
    }

    internal class Program
    {
        // delegate는 메소드를 보관하기 위한 메소드와 반환형이
        // 일치해야 합니다.

        // delegate는 메소드를 보관하기 위한 메소드의 매개변수가
        // 일치해야합니다.
        delegate void Function(int x, int y);

        static void Plus(int x, int y)
        {
            Console.WriteLine("x + y : " + (x + y));
        }

        static void Minus(int x, int y)
        {
            Console.WriteLine("x - y : " + (x - y));
        }

        static void Main(string[] args)
        {
            #region 델리게이트

            // Function function;
            // 
            // function = Plus;
            // function(10, 20);
            // 
            // function = Minus;
            // function(10, 25);

            #endregion

            #region 델리게이트 체인
            // Function function;
            //
            // // delegate 체인을 하려면 먼저 메소드를 등록시키고 추가해주어야 합니다.
            // function = Plus;
            // function += Minus;
            //
            // function(10, 35);
            //
            // function -= Minus;
            //
            // function(1, 9);
            #endregion

            Player player = new Player();
            Enemy enemy = new Enemy();

            player.Damage(enemy);
        }
    }
}