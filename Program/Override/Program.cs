using System.Runtime.CompilerServices;

namespace Override
{
    class Weapon
    {
        private string name;
        // private int itemType;

        public enum itemType
        { 
           Sword,
           Gun,
           Arrow
        }

        public Weapon()
        {
            Console.WriteLine("매개 변수가 없는 생성자 호출");
        }

        public Weapon(string name)
        {
            this.name = name;
            Console.WriteLine("매개 변수가 있는 생성자 호출");
        }

        public void Select(itemType item)
        {
            switch (item)
            {
                case itemType.Sword : Console.WriteLine("Sword");
                  break;
                case itemType.Gun : Console.WriteLine("Gun");
                    break;
                case itemType.Arrow : Console.WriteLine("Arrow");
                    break;
            }
        }

        // 함수의 오버로딩
        public void Attack(int damage)
        {
            Console.WriteLine("int Damage : " + damage);
        }

        public void Attack(float damage)
        {
            Console.WriteLine("float Damage : " + damage);
        }
    }

    class Monster
    {
        virtual public void Attack( )
        {
            Console.WriteLine("Monster 공격");
        }
    }

    class Goblin : Monster
    {
        override public void Attack( )
        {
            Console.WriteLine("Goblin 공격");
        }          
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 함수의 오버로딩
            // Weapon weapon = new Weapon("Sword");
            //
            // Attack(int)
            // weapon.Attack(100);
            //
            // Attack(float)
            // weapon.Attack(50.5f);
            #endregion

            #region Enum
            // Weapon weapon = new Weapon();
            //
            // weapon.Select(Weapon.itemType.Gun);
            // weapon.Select(Weapon.itemType.Arrow);
            // weapon.Select(Weapon.itemType.Sword);
            #endregion

            Monster monster = new Goblin();
            monster.Attack();

        }
    }
}