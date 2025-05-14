using static System.Console;
namespace _2025_04_22_CSharp
{
    internal class Program
    {
        //정적 할당 : 미리 할당됨
        //동적 할당 : 필요할때 마다 할당됨
        // 매개변수 : 전달 인자를 입력 받는 곳
        //static void Main(string[] args)
        //{
        //    #region Write

        //    //Write("Hi~");
        //    //Write("\n정수 입력 : \n");
        //    //int n1 = int.Parse(ReadLine()!);
        //    //int n2 = int.Parse(ReadLine()!);
        //    //WriteLine("\n 더하기 곱하기 나누기 나머지 결과 값을 출력 하세요\n");


        //    //// WriteLine($" 더한 값 :({n1+n2}) , 곱한 값 ({n1*n2}) 나누기 값 : ({n1/n2}) 나머지 값 : ({n1%n2})");
        //    //WriteLine($"더하기 : {n1} + {n2} = {n1 + n2}");
        //    //WriteLine($"곱하기 : {n1} * {n2} = {n1 * n2}");
        //    //WriteLine($"나누기 : {n1} / {n2} = {n1 / n2}");
        //    //WriteLine($"나머지 : {n1} % {n2} = {n1 % n2}");
        //    //// 디버깅 : 버그를 해결하는 곳
        //    #endregion

        //    #region 메인 메서드 매개변수 args 사용 방법 로직
        //    //if (args.Length == 0) //문자열의 길이가 0이면
        //    //{
        //    //    WriteLine($"2025-04-22-CSharp"); // 라인 출력
        //    //    return; // 위의 조건에 맞다면 빠져 나감
        //    //}
        //    //// 위의 조건이 아니라면 첫번째 문자열을 출력
        //    //for (int i = 0; i < args.Length; i++) 
        //    //WriteLine($"2025-04-22-CSharp {args[i]}");
        //    #endregion

        //    #region 기본 데이터 형식
        //    //sbyte a = -10;
        //    //byte b = 40;
        //    //WriteLine($"a = {a} b = {b} = 뺄셈 : {a-b}");

        //    //short c = -30000;
        //    //ushort d = 60000;
        //    //WriteLine($"c = {c} d = {d} = 뺄셈 : {c-d}");

        //    //int e = -1000_0000;
        //    //uint f = 3_0000_0000; // _ 구분자
        //    //WriteLine($"e = {e} f = {f} = 뺄셈 : {e - f}");

        //    //long g = -5000_0000_0000;
        //    //ulong h = 200_0000_0000_0000;
        //    //WriteLine($"g = {g} h = {h}");
        //    #endregion

        //    #region 이진수 16진수를 십진수로 변환
        //    //sbyte a = -10;
        //    //sbyte b = -5000_0000_0000; // 값이 넘치는 현상은 overFlow라고 한다.

        //    //byte a = 240;// 10진수 리터럴 상수
        //    //WriteLine($"a = {a}");

        //    ////int sum = 20 + 30;
        //    //byte b = 0b111_0000; // 2진수 리터럴(literal) 상수
        //    //WriteLine($"b = {b}");

        //    //byte c = 0xF0; // 16진수 리터럴 상수
        //    //WriteLine($"c = {c}");

        //    //uint d = 0x1234_abcd; // 16진수 리터럴
        //    //WriteLine($"d = {d}");

        //    #endregion

        //    #region overFlow 되는 로직
        //    //byte a = 255;
        //    //sbyte b = (sbyte)a; // (형변환) 캐스팅

        //    //WriteLine(a);
        //    //WriteLine(b);

        //    //uint a = uint.MaxValue;
        //    //a += 1;
        //    //WriteLine(a);

        //    //uint b = uint.MinValue;
        //    //WriteLine(b);
        //    #endregion

        //    #region 부동소수점을 표현하는 자료형들

        //    ////4바이트 소수점 7자리의 정밀도
        //    //float a = 3.1415_9265_3589_7963f;
        //    //WriteLine(a);
        //    ////8바이트 소수점 15~16자리의 정밀도
        //    //double b = 3.1415_9265_3589_7963_46234d;
        //    //WriteLine(b);
        //    ////29~30 자리의 정밀도    16바이트 
        //    //decimal c = 3.1415_9265_3589_7963_46234123456789m;
        //    //WriteLine(c);
        //    #endregion

        //    #region char string의 차이

        //    ////2byte , 글자 하나 또는 정수를 표현 하기도 함 유니코드
        //    //char a = '안';
        //    //char b = '녕';
        //    //char c = '하';
        //    //char d = '세';
        //    //char e = '요';
        //    //string str = "안녕하세요 !";

        //    //WriteLine(a);
        //    //WriteLine(b);   
        //    //WriteLine(c);
        //    //WriteLine(d);   
        //    //WriteLine(e);
        //    //WriteLine(str);

        //    #endregion

        //    #region Object

        //    // object 모든 자료형들의 부모, 참조형식 (heap) , 모든 자료형을 받아서 쓸 수가 있다.
        //    //bool isDead = false; 

        //    //object a = 123;
        //    //object b = 3.1415;
        //    //object c = "안녕하세요";
        //    //// 힙(heap) 참조형 데이터
        //    //object d = true;
        //    //WriteLine($"{a}\t {b} \t{c}\t {d}");

        //    //int a = 123;
        //    //object b = (object)a; // 박싱 : 값 형식을 힙 메모리에 저장하고 참조를 통해 접근할 수 있도록 만드는 것
        //    //int c = (int)b; // 언박싱 : 박싱된 값은 힙 메모리에 저장된 값 형식이고, 이를 다시 스택 메모리로 옮겨서 원래의 값 형식으로 사용하기 위해 언박싱이 필요함

        //    //WriteLine($"{a} {b} {c}");

        //    #endregion
            
        //    //sbyte a = 127; // 0111 1111
        //    //WriteLine(a);

        //    //int b = (int)a;
        //    //int x = 128;
        //    //WriteLine(x);
        //    //sbyte y = (sbyte)x;
        //    //WriteLine(y);
        //}
    }
}
