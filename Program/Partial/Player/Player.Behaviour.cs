namespace Partial
{
    // partial 클래스로 선언한 클래스는 접근 지정자가 다 똑같이 
    // 설정되어 있어야 합니다.
    internal partial class Player
    {
        public void MoveMent()
        {
            Console.WriteLine("플레이어 이동");
        }

        public void Attack()
        {
            Console.WriteLine("플레이어 공격");
        }
    }
}
