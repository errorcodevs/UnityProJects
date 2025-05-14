using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2025_04_22_CSharp
{
    //enum DialogResult { YES = 1, NO, CANCEL, CONFIRM, OK};
    //enum MUSIC { DO=3, RE, ME, FA, SOL, RA, SI}
    internal class MainApp
    {
        static void Main(string[] args)
        {
            #region underflow(언더플로우)
            //float a = 0.9f;
            //int b = (int)a; //데이터 손실

            //WriteLine($"{a} {b}");
            //double e = 3.1415d;
            //int f = (int)e;
            //WriteLine(f);
            //int g = -500;
            //uint h = (uint)g; // 언더플로우
            //WriteLine(h);

            //int x = -30;
            //uint y = (uint)x; // 언더플로우
            //WriteLine(y);
            #endregion

            #region 형 변환
            //float hp = 100f;
            //float damage = 20.5f;
            //int result = 0;

            //result = (int)(hp -= damage);
            //WriteLine(result);

            //float c = 1.1f;
            //int d = (int)c;
            //WriteLine(d);

            //string a = "12345";

            //int b = int.Parse(a);   
            //WriteLine(b);

            //string PI = "3.1415";
            //float fPI = float.Parse(PI); // parsing
            //WriteLine(fPI);

            //int a = 123;
            //string b = a.ToString();
            //WriteLine(b);

            //string e = "123456789";
            //int f = Convert.ToInt32(e);
            //WriteLine(f);

            //string g = "1.2345";
            //float f = Convert.ToSingle(g);
            //WriteLine(f);

            //string gg = "3.141523456789";
            //double hh = Convert.ToDouble(gg);
            //WriteLine(hh);
            #endregion

            #region 상수

            //상수 변수
            //int n1 = 0;
            //WriteLine(++n1);
            //WriteLine(n1++);
            //WriteLine(n1);

            //WriteLine(--n1);
            //WriteLine(n1--);
            //WriteLine(n1);
            //const double PI = 3.1415d;
            //상수 : 선언과 동시에 초기화
            // PI++; 변수가 아니라서 오류 
            // const double Max; 선언만
            //Max = 29.45678d; // 초기화 따로 하면 오류

            //int n1 = 100;
            //int n2 = (n1++)+ 100;
            //WriteLine($"{n1} {n2}");     
            #endregion

            #region 열거형 상수 Nullable, enum
            //열거형 상수
            //Write($"{(int)DialogResult.YES}\n");
            //Write($"{(int)DialogResult.NO}\n");
            //Write($"{(int)DialogResult.CANCEL}\n");
            //Write($"{(int)DialogResult.CONFIRM}\n");
            //Write($"{(int)DialogResult.OK} \n");
            //Write($"{(int)MUSIC.DO} \n");
            //Write($"{(int)MUSIC.RE} \n");
            //Write($"{(int)MUSIC.FA} \n");
            //Write($"{(int)MUSIC.SOL} \n");
            //Write($"{(int)MUSIC.RA} \n");
            //Write($"{(int)MUSIC.SI} \n");

            // 우리가 프로그래밍 하다보면 가끔씩 비어 있는 값을 어떠한 값도 가지지 않는 변수가 필요 할 때 
            // Nullable을 쓴다. 즉 비어있는 상태

            //int? a = null; // null = 비어있는 값 , ? = null을 허용함

            //WriteLine(a.HasValue); // HasValue == Bool

            //WriteLine(a != null); // 같지않다
            ////WriteLine(a == null); // 같다

            //a = 3;

            //WriteLine(a.HasValue);
            //WriteLine(a != null); // 같지않다

            //WriteLine(a!.Value);

            #endregion

            #region var 자료형

            // var는 똑똑한 자료형, C# 형식 검사를 깐깐하게 하지만 예외가 있다 그것이 바로 var

            //var a = 20; var b = "안녕하세요"; // 선언과 동시에 초기화, 지역 변수에서만 선언 가능
            //var c = 3.1415; var d = "a"; // 선언과 동시에 초기화, 지역변수에서만 선언 가능
            //WriteLine($"{a} \t {b}\t {c}\t {d}\t");

            // var a = 20;
            //WriteLine("Type : {0}, Value : {1}", a.GetType(), a);
            //WriteLine($"Type : {a.GetType()}, Value : {a}");


            #endregion

            #region 공용 형식 시스템
            // 공용 형식 시스템 Common Type System (CTS) 

            //System.Int32 a = 123;
            //int b = 123;

            //WriteLine($"aType:{a.GetType()} {a}");
            //WriteLine($"bType:{b.GetType()} {b}");
            //System.String c = "abc";
            //WriteLine($"cType :{c.GetType()} {c}");
            //// string d = "abc";

            #endregion

            #region 문제 1

            //WriteLine("사각형의 너비를 입력하세요.");
            //string width = ReadLine()!;

            //WriteLine("사각형의 높이를 입력하세요.");
            //string height = ReadLine()!;

            //WriteLine($"사각형의 너비는 : {width}, 사각형의 높이는 : {height}, 사격형의 넓이는 : {float.Parse(width) * float.Parse(height)}");

            #endregion

            #region 문제5
            //var a = 2020;
            //var b = "double";

            //WriteLine($"Type : {a.GetType()}, Value : {a}");
            //WriteLine($"Type : {b.GetType()}, Value : {b}");
            #endregion
        }
    }
}
