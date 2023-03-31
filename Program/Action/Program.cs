using System;
using System.Diagnostics;

struct DataTable
{
    public int memory;
    public int [] array;
}

class A
{ 
   public A()
   {
        Console.WriteLine("A 클래스");
   }
}

class B
{
    public B(string name)
    {
        Console.WriteLine("B 클래스" + name);
    }
}


class Language<T> where T : struct
{
    // where T : struct 
    // null을 허용하지 않는 값 형식이어야 합니다.

    // where T : class
    // 참조 형식이어야 합니다.

    // where T : new()
    // 매개 변수가 없는 public 생성자가 있어야 합니다.

    // where T : unmanaged <- struct 안에 참조 타입을 포함하지 않습니다.
    // T는 null이 아닌 비관리형 형식이어야 합니다.
    // char, byte, bool, int, float, double, decimal

    // where T : <base class name>
    // 지정된 기본 클래스이거나 이 클래스에서 파생된 클래스여야 합니다. 
    
    private T data;

    public T Data
    {
        get { return data; }

        set { data = value; }
    }
}

internal class Program
{
    static void Close()
    {
        Console.WriteLine("Close");
    }

    static void Open(int power)
    {
        Console.WriteLine("문을 여는 힘 : " + power);
    }

    static int Score()
    {
        return 100;
    }

    static int Result(int value)
    {
        return value;
    }

    static void Main(string[] args)
    {
        #region Action
        // Action action;
        // Action<int> intAction;
        //
        // action = Close;
        // action();
        //
        // action = () => { Console.WriteLine("로그인 성공"); };
        // action();
        //
        // intAction = Open;
        // intAction(100);
        //
        // intAction = (x) => { Console.WriteLine("로그인 실패 횟수 : " + x); };
        // intAction(3);
        #endregion

        #region Func
        //Func<int> func;
        //
        //// Func는 <반환형, 매개변수>
        //Func<int, int> intFunc;
        //
        //func = Score;
        //
        //Console.WriteLine("Score : " + func());
        //
        //func = () => { return 999; };
        //
        //Console.WriteLine("Score : " + func());
        //
        //intFunc = Result;
        //
        //Console.WriteLine("Result : " + intFunc(1000));
        //
        //intFunc = (x) => { return x; };
        //
        //Console.WriteLine("Result : " + intFunc(222));
        //
        #endregion

        #region 제약 조건 (where)
        // Language<int> language = new Language<int>();
        // language.Data = 100;
        // 
        // Console.WriteLine(language.Data);
        // 
        // Language<A> language3 = new Language<A>();
        // Language<B> language4 = new Language<B>();
        // Language<string> language1 = new Language<string>();
        // Language<DataTable> language2 = new Language<DataTable>();
        // 
        #endregion
    }
}
