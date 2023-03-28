using System.Linq.Expressions;

namespace Anonymous
{
    class Vector<T>
    {
        private T [] element = new T[10]; 

        public Vector()
        {
            for(int i = 0; i < element.Length; i++)
            {
                Console.WriteLine(element.Length);
            }
        }

        public T Index(int index)
        {
            return element[index];
        }
    }

    internal class Program
    {
        delegate int Calculator(int x, int y);

        // <T> 형식 매개변수
        // 호출할 때 < > 사이에 T 대신 형식의 이름을 넣으면
        // 컴파일러는 메서드의 나머지 부분에 대해서도 T를 형식 매개 변수 값으로 치환합니다.
        static void Resolution<T>(T x, T y)
        {   
            Console.WriteLine("x 해상도 : " + x + " " + "y 해상도 : " + y);
        }

        static void Main(string[] args)
        {
            #region 무명 형식

            // 이름이 없는 형식으로 선언과 동시에 인스턴스를 할당합니다.
            //
            // var instance = new 
            // {
            //    name = "James",
            //    age = 19
            // };
            //
            // 무명 형식은 값을 참조해서 수정할 수 없습니다.
            // instance.name = "Jone";
            //
            //Console.WriteLine(instance.name);
            //Console.WriteLine(instance.age);

            #endregion

            #region 무명 메소드

            // Calculator calculator;
            //
            // calculator = delegate(int x, int y)
            //              {
            //                   return x + y;
            //              };
            //
            // 무명 메소드도 delegate 타입과 일치해야 합니다.
            // 
            // calculator = delegate(float x, float y)
            //              {
            //                  return x - y;
            //              }
            // 
            //
            // Console.WriteLine(calculator(10,20));
            //
            // 람다식(Lamda Expression)
            // calculator = (x, y) => x * y;
            // 
            // Console.WriteLine(calculator(5, 5));
            #endregion

            // 일반화 프로그래밍
            // 데이터 형식(Data Type)을 정해놓고 사용하는 게 아니라
            // 특수한 형식을 사용하는 코드의 데이터 형식을 일반화하여 
            // 오버로딩하지 않고, 모든 형식을 지원할 수 있는 프로그래밍 방법입니다.
            Resolution<int>(10, 20);
            Resolution<float>(1925.5f, 1300.5f);

            Vector<int> vector = new Vector<int>();

            Console.WriteLine(vector.Index(9));
        }
    }
}