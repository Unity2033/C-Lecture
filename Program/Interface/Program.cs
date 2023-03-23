namespace Interface
{
    interface IMouse
    {
        // 기본 접근 지정자 (public)
        void Drag();

        // 인터페이스는 변수를 선언할 수 없습니다.
        // int value;
    }

    interface IKeyBoard
    {
        void Typing();
    }

    class Computer : IMouse, IKeyBoard
    {
        // 자동 구현 프로퍼티
        public float Signal
        {
            get;
            set;
        } = 16.5f;

        // 선택적 매개변수
        public void Power(string button, bool power = false)
        {
            Console.WriteLine("전원의 상태 : " + power);
        }

        // 명명된 매개변수 
        public void Information(string name, int year)
        {
            Console.WriteLine("컴퓨터의 이름 : " + name);
            Console.WriteLine("컴퓨터의 제작년도 : " + year);
        }

        public void Drag()
        {
            Console.WriteLine("Computer Mouse Drag");
        }

        public void Typing()
        {
            Console.WriteLine("Computer Keyboard Type");
        }
    }

    class CellPhone : IMouse
    {
        public void Drag()
        {
            Console.WriteLine("CellPhone Touch Drag");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스

            // Computer computer = new Computer();
            // CellPhone cellPhone = new CellPhone();
            //
            // // 참조 변수로 사용 가능합니다.
            // IMouse mouse = computer;
            // mouse.Drag();
            //
            // mouse = cellPhone;
            // mouse.Drag();
            //
            // computer.Drag();
            // computer.Typing();
            //
            // cellPhone.Drag();
            #endregion

            Computer computer = new Computer();

            // computer.Power("Force Quit Button");
            // computer.Power("Force Quit Button", true);

            computer.Information("LG Computer", 2023);
            computer.Information(year : 1999, name : "Samsung Computer");

            //computer.Signal = 100.0f;
            Console.WriteLine("Signal의 값 : " + computer.Signal);
        }
    }
}