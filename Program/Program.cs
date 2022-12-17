using System;

namespace Program
{
    class Unit
    { 
        // call by pass 
        // 인수로 전달되는 변수가 가지고 있는 값을
        // 메소드 내의 매개 변수에 복사되는 방식입니다.
        public void Function(int x)
        {
            x = 100;
        }        

        // call by reference (ref)
        // 메소드의 매개변수에 인수로 전달된 변수의 원래
        // 주솟값을 저장하는 방식입니다.
        public void Calculator(ref int x)
        {
            x = 1000;
        }

        // call by reference (out)
        public void Information(out int x)
        {
            // 출력용 매개변수는 메소드 내부에서
            // 값을 초기화하지 않으면 사용할 수 없습니다.
            x = 10000;
        }

        // call by reference (in) 
        public void DataPacket(in int x)
        {
            int variable = x + x;
            Console.WriteLine("x의 값 : " + x);
        }

        // 가변 길이 매개변수
        public void ItemSetting(params int [] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("x [" + i + "]의 값 : " + x[i]);
            }
        }

        // 선택적 매개변수
        // 메소드의 매개변수는 기본값을 가질 수 있도록 설정해주는
        // 매개변수입니다.

        public void Stat(int x, int y = 10)
        {
            // 선택적 매개변수에 값을 저장하려면 오른쪽에서 부터
            // 기본값을 설정해주어야 합니다.
            Console.WriteLine("x의 값 : " + x + " y의 값 : " + y);
        }

    }

    // 프로퍼티
    class Champion
    {
        // 체력
        private float health;
        
        // 클래스 내부에 있는 데이터를 숨기고, 외부에 사용할 수 있는
        // 인터페이스만 제공해주는 기능입니다.
    
        public float Health
        {
            get { return Health; } // 출력해주는 기능
            set 
            { 
                if(value > 100)
                {
                    return; 
                }

                health = value;  
            } // 입력해주는 기능
        }

    }

    // OOP 4대 특징
    // 1. 추상화
    // 2. 캡슐화
    // 3. 상속
    // 4. 다형성

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 매개변수 한정자

            Unit unit = new Unit();

            int value = 10;

            // 값에 의한 전달
            // unit.Function(value);
            // Console.WriteLine("value의 값 : " + value);

            // 참조에 의한 전달 (ref)
            // unit.Calculator(ref value);
            // Console.WriteLine("value의 값 : " + value);

            // 참조에 의한 전달 (out)
            // out 키워드는 지역 변수의 값을 초기화하지 않아도
            // 사용할 수 있습니다.
            // unit.Information(out value);
            // Console.WriteLine("value의 값 : " + value);

            // 참조에 의한 전달 (in)
            // in 키워드는 메소드 내부에서 값을 변경할 수 없습니다.
            // unit.DataPacket(value);
            // Console.WriteLine("value의 값 : " + value);

            // 가변 길이 매개변수
            // 가변 길이 매개변수에 인수를 전달하지 않으면 
            // 배열의 크기는 0으로 설정됩니다.
            // unit.ItemSetting(5, 7, 9, 1);
            // unit.ItemSetting(20, 15);
            // unit.ItemSetting();

            // 선택적 매개변수
            // unit.Stat(1); // x : 1, y : 10
            // unit.Stat(20, 95); // x : 20, y : 95
            #endregion

            // 프로퍼티
            Champion alistar = new Champion();

            alistar.Health = 99; // set
            Console.WriteLine("alistar의 체력 : " + alistar.Health); // get
        }
    }
}
