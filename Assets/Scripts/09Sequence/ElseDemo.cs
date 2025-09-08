using UnityEngine;


public class ElseDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            //실행문1
            Debug.Log("조건식이 참이면 실행문1을 실행합니다");
        }
        else
        {
            //실행문2
            Debug.Log("조건식이 거짓이면 실행문2를 실행합니다");
        }

    }

}

/* Else문 : 아니면 (if문에 붙여서 사용)  
 * {if의 조건식이 정상적으로 실행 되었을때 else는 실행되지 않음}
 
if의 조건식이 참일때면 else의 실행문 2는 실행하지 않습니다
if 조건식이 거짓일때 else의 실행문 2를 실행합니다

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
if(조건식) 
{
    (실행문1)
}

else
{
    (실행문2)
}

    (실행문3)
ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

조건식이 참일경우 실행문1 -> 실행문3 실행
조건식이 거짓일경우 실행문2 -> 실행문3 실행
*/