namespace Game
{
    class IPhone
    {
        #region 함수
        // 하나의 특별한 목적의 작업을 수행하기 위해 독립적으로
        // 설계된 코드의 집합입니다.
        private int volume;

        public void Modify()
        {
            Console.WriteLine("조작하다.");
        }

        // 함수의 경우 자료형과 반환하는 값의 형태가 일치하지
        // 않으면, 원하는 값을 얻을 수 없으며, 같은 이름의
        // 함수를 중복으로 선언할 수 없습니다.

        public int GetVolume()
        {
            return volume;
        }

        // 매개 변수란?
        // 함수의 정의에서 전달받은 인수를 함수 내부로
        // 전달하기 위해 사용하는 변수입니다.
        public void SetVolume(int value)
        {
            // 매개 변수는 함수 내부에서만 연산이 이루어지며,
            // 함수가 종료되면 메모리에서 사라집니다.
            volume = value;
        }

        #endregion
    }

    internal class Program
    {
        static void Main(string[] args) 
        {
            #region 인수
            // 함수가 호출될 때 매개 변수에 실제로 전달되는 값입니다.
            IPhone se3 = new IPhone();

            se3.Modify();
            
            se3.SetVolume(50);

            Console.WriteLine(se3.GetVolume());
            #endregion
        }
    }
}