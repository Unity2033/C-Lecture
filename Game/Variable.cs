using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Variable
    {
        // static void Main( ) : 프로그램이 실행되는 진입점입니다. 

        static void Main(string[] args)
        {
            // Console.WriteLine() : 특정한 문자열을 출력하는 함수입니다.
            // ("C# Language")
            // 세미콜론 (;) : 한 문장의 끝을 알려주는 기호입니다. 
            // Console.WriteLine("게임");

            #region 변수
            // 데이터를 저장할 수 있는 메모리 공간을
            // 생성하는 것입니다.

            // 자료형이란?
            // 데이터를 저장하기 위해 데이터의 형태를 정해주는 것입니다.

            // etc..형
            // bool   <- 1 byte
            // bool data = false;
            // Console.WriteLine("data 변수의 값 : " + data);
            // 
            // // 문자형
            // // char   <- 1 byte 
            // char alphabet = 'A';
            // Console.WriteLine("alphabet 변수의 값 : " + alphabet);
            // 
            // // 정수형  
            // // short  <- 2 byte
            // // int    <- 4 byte
            // int attack = 10;
            // Console.WriteLine("attack 변수의 값 : " + attack);
            // 
            // // 실수형
            // // float  <- 4 byte
            // // double <- 8 byte
            // float exp = 99.75f;
            // Console.WriteLine("exp 변수의 값 : " + exp);
            // 
            // // 문자열형
            // // string <- 16 byte
            // string name = "Goblin";
            // Console.WriteLine("name 변수의 값 : " + name);
            #endregion

            #region 변수의 이름 규칙
            // 1. 변수의 이름으로 숫자로 시작할 수 없습니다.
            // ex) int 5i = 10;

            // 2. 변수의 이름에 공백이 포함될 수 없습니다.
            // ex) int level UP = 30;

            // 3. 변수의 이름은 대소문자를 구분합니다.
            // ex) int value = 20;
            // ex) int VALUE = 30;

            // 4. 변수의 이름으로 예약어를 사용할 수 없습니다.
            // ex) int decimal = 10;

            // 5. 변수의 이름으로 특수 기호는 "_"만 사용 가능합니다.
            // ex) int level_Up = 1;
            #endregion

            #region 상수
            // 프로그램이 실행되는 동안 더 이상 변경할 수 없는
            // 메모리 공간입니다.

            // int count = 0;
            // 
            // count = 100;
            // 
            // // 상수는 메모리 공간을 생성하는 동시에 초기화해야 하며,
            // // 한 번 저장된 값은 더 이상 변경할 수 없습니다.
            // const float pi = 3.141592f;

            // 심볼릭 상수란?
            // 메모리 공간을 가지고 있는 상수입니다. 

            // 리터럴 상수란?
            // 메모리 공간을 가지고 있지 않은 상수입니다.

            // pi = 5.75f;

            #endregion
        }
    }
}
