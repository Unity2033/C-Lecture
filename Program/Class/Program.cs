using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace Class
{
    class Dog
    {
        // 접근 지정자    
        // public : 클래스 외부로 부터 접근을 허용하는 지정자입니다.
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value >= 18)
                {
                    value = 18;
                }

                age = value;
            }
        }


        protected char grade;

        private float health;
        // protected : 자기 자신의 클래스와 자기가 상속하고 있는
        //             클래스에서 접근을 허용하는 지정자입니다.

        // private : 클래스 내부에서만 접근을 허용하는 지정자입니다.
    }

    class Maltese : Dog
    {
        public void Information()
        {
            grade = 'A';
            Console.WriteLine("등급 : " + grade);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 클래스
            // Dog dog = new Dog();

            // dog.Age = 13334;         
            // Console.WriteLine("dog.Age의 값 : " + dog.Age);

            // Maltese maltese = new Maltese();
            // maltese.Information();
            #endregion

            // 단어 길이 재기
            string content = Console.ReadLine();

            Console.WriteLine(content.Length);
        }
    }
}