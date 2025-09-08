using UnityEngine;

// ElseIf 문
//두개의 정수 number1, number2를 입력받아
// 1. number1이 크면 "number1이 큽니다" 출력
// 2. number2이 크면 "number2이 큽니다" 출력
// 3. 나머지는 "두 수의 크기가 같습니다" 출력
public class IfElseIfElse : MonoBehaviour
{
    //두개의 변수 선언하고 0으로 초기화
    public int number1 = 0;
    public int number2 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //두개의 수 중 큰 수 찾기
        // number1 이 크다면
        if (number1 > number2) //
        {
            //실행문1
            Debug.Log("number1이 큽니다");
        }
        else if (number1 < number2) // number2가 크다면 
        {
            //실행문2
            Debug.Log("number2가 큽니다");
        }
        else // 둘다 아니면
        {
            //실행문3
            Debug.Log("두 수의 크기가 같습니다");
        }

        //실행문4
        Debug.Log("종료");


    }

}

// 조건문 두개가 모두 참일때, 선언문 ㅡ> 실행문1 ㅡ> else는 조건부가 거짓일때만 작동하기에 실행문 2는 실행되지 않고 실행문4 로 넘어간다.