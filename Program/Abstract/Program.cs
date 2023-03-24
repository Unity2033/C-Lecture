namespace Abstract
{
    // 추상 클래스 
    abstract class Item
    {
        protected int price = 1000;

        abstract public void Function(); // <- 하나 이상의 추상 메소드가 포함되어 있어야 합니다. 

        abstract public void WaitTime();

        public void Information()
        {
            Console.WriteLine("Item의 가격 : " + price);
        }
    }

    class Posion : Item
    {
        const string type = "포션류";

        public readonly int itemCode = 100;

        public Posion()
        {
            itemCode = 2123151;
            Console.WriteLine("item Code : " + itemCode);
        }

        new public void Information()
        {
            base.Information();
            Console.WriteLine("포션 가격 : " + price);
        }

        public override void Function()
        {     
            Console.WriteLine("능력치 증가");
        }

        sealed public override void WaitTime()
        {
            Console.WriteLine("몇 초 대기");
        }
    }

    class HealthPosion : Posion
    {
        public override void Function()
        {
            Console.WriteLine("체력 회복");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Item item = new Item();

            #region 추상 클래스
            // Item item = new Posion();
            // item.Function();
            // item.Information();
            #endregion

            #region base 키워드
            // Posion posion = new Posion();
            // posion.Information();
            #endregion

            // 문자열 보간
            int year = 2023;

            var date = DateTime.Now;

            Console.WriteLine("{0}년 {1:HH:mm} 분", year, date);
        }
    }
}