namespace Boxing
{
    class Monster
    {
        // 클래스란?
        // 사용자 정의 데이터 유형으로 속성과 함수가 포함되어 있으며,
        // 클래스를 통해 객체를 생성하여 접근하고 사용할 수 있는 집합체입니다.

        // 접근 지정자
        /*
        // 클래스 내에서 접근을 제한하는 지정자입니다.

        // public : 클래스 외부와 클래스 내부에서 접근
        //          할 수 있는 지정자입니다

        // private : 클래스 내부에서만 접근할 수 있는
        //           지정자입니다.

        // protected : 클래스 내부와 자기가 상속하고 있는
        //             클래스까지만 접근할 수 있는 지정자입니다.
        */

        // 기본 접근 지정자 (private)
        public int health;
        public int attack;
        public string name;

        public void Skill()
        {
            Console.WriteLine("방망이 던지기");
        }
    }

    internal class Program
    {

        // [자료형] [함수의 이름](매개변수)
        // {
        //
        //
        // }

        // void = 자료형이 없는 형태

        static void Function()
        {
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("안녕하세요.");
            Console.WriteLine("안녕하세요.");
        }

        static int Calculator()
        {
            // 메소드는 하나의 값만 반환할 수 있습니다.
            return 50;

            int value = 10 + 20;

            // 메소드의 자료형과 반환하는 값의 형태가
            // 일치하지 않으면 원하는 값을 없을 수 없으며,
            // 같은 이름의 메소드를 중복으로 선언할 수 없습니다.
            return value;
        }

        static void Attack(int x)
        {
            // 매개변수 
            // 함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해
            // 사용하는 변수입니다.

            x = 300;
        }

        static void Main(string[] args)
        {
            #region 객체 인스턴스
            /*
            Monster monster = new Monster();
            monster.health = 100;
            monster.attack = 20;
            monster.name = "Goblin";
            monster.Skill();

            Console.WriteLine("monster의 체력 : " + monster.health);
            Console.WriteLine("monster의 공격력 : " + monster.attack);
            Console.WriteLine("monster의 이름 : " + monster.name);
            */
            #endregion

            #region 박싱과 언박싱
            /*
            // object는 어떤 형식의 데이터라도 object에
            // 저장할 수 있습니다.

            int value1 = 10;
            float value2 = 10.75f;
            bool value3 = true;
            char value4 = 'A';

            // 박싱(Boxing) 
            // 값 형식을 object 형식으로 변환하는 과정입니다.
          
            // 암묵적 형 변환
            object obj1 = value1;
            object obj2 = value2;
            object obj3 = value3;
            object obj4 = value4;
           
            // 언박싱(UnBoxing)
            // object 형식 개체에 Boxing 상태의 값 형식
            // 데이터를 추출하는 과정입니다.

            // 명시적 형 변환
            int data1 = (int)obj1;
            float data2 = (float)obj2;
            bool data3 = (bool)obj3;
            char data4 = (char)obj4;

            Console.WriteLine("data1의 값 : " + data1);
            Console.WriteLine("data2의 값 : " + data2);
            Console.WriteLine("data3의 값 : " + data3);
            Console.WriteLine("data4의 값 : " + data4);

            object [] array = new object[5];
            array[0] = 10;
            array[1] = "name";

            // 저장되는 공간이 다르고 불필요한 형 변환이
            // 이루어지기 때문에 오버헤드 현상이 발생합니다.
            */
            #endregion

            // 메소드
            // 하나의 특별한 목적의 작업을 수행하기 위해 독립적으로
            // 설계된 코드의 집합입니다.
            Function();
            Function();
            Function();

            int value1 = 10;

            // 인수
            // 메소드가 호출될 때 매개변수에 실제로 전달되는 값입니다.
            Attack(value1);

            // 인수는 값을 전달하는 인수와 값을 전달받는 매개변수의 자료형이 서로
            // 일치해야 합니다.

            Console.WriteLine("value1의 값 : " + value1);

            Console.WriteLine("Calculator 반환하는 값 : " + Calculator());

            Console.ReadLine(); // 입력하는 메소드

            // 시작 프로그램으로 설정된 프로젝트의 이름은
            // 굵은 글씨로 정의되어 있습니다.
        }
    }
}