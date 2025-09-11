using System;
using Unity.Mathematics;
using UnityEngine;

public class FunctionPlusMinus : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = Add(6, 3);
        Debug.Log($"6+3={result}");
        result = Subtract(6, 3);
        Debug.Log($"6-3={result}");
        result = Multiply(6, 3);
        Debug.Log($"6*3={result}");
        result = Divide(6, 3);
        Debug.Log($"6/3={result}");
        result = Percent(6, 3);
        Debug.Log($"6%3={result}");

    }
    //수와 연산자를 대입시 계산해주는 식
    int Calculate(int a, int b, char op)
    {
        if (op == '+')
        {
            return a + b;
        }
        else if (op == '-')
        {
            return a - b;
        }
        else if (op == '*')
        {
            return a * b;
        }
        else if (op == '/')
        {
            if (b == 0)
            {
                Console.WriteLine("0으로 나눌 수 없습니다!");
                return 0;
            }
            return a / b;
        }
        else if (op == '%')
        {
            return a % b;
        }
        else
        {
            Console.WriteLine("잘못된 연산자입니다!");
            return 0;
        }
    }


    int Add(int x, int y)
        { 
            return x + y;
        }
    int Subtract(int x, int y) { return x - y; }

    int Multiply(int x, int y) => x * y;
    int Divide(int x, int y) => x / y;
    int Percent(int x, int y) => x % y;












}
/*
  사칙연산을 구하는 함수 만들기
 -매개변수로 두개의 정수를 입력받아 +,-,*,/,% 연산한다
 -연산 결과 값을 반환하는 함수 구현

입력값 6, 3
6+3
6-3
....
 */