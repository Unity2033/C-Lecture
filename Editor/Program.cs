namespace Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 반복문
            // 프로그램 내에서 특정한 작업을 반복적으로
            // 수행하는 명령문입니다.

            // 증감 연산자란?
            // 피연산자를 하나씩 증가시키거나 감소시킬 때
            // 사용하는 연산자입니다.

            // 전위 증감 연산자
            /*
            // 변수의 값을 증감시킨 후에 연산을 수행하는 연산자입니다.
            int data = 0;

            data = ++data;

            Console.WriteLine("data의 값 : " + data);

            data = --data;

            Console.WriteLine("data의 값 : " + data);
            */

            // 후위 증감 연산자
            // 연산을 수행한 다음 변수의 값을 증감시키는 연산자입니다.

            int health = 0;
            int damage = 1;

            health = damage--;

            Console.WriteLine("health의 값 : " + health);

            health = damage++;

            Console.WriteLine("health의 값 : " + health);
            #endregion

        }
    }
}