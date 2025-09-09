using JetBrains.Annotations;
using UnityEngine;

public class IfElseOr : MonoBehaviour
{
    //정수형 변수 선인 및 초기화
    public int a = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //입력받은 수가 짝수이면 "{a}는 짝수" 출력
        //if문 짝수 판별식

        /* if (a%2 == 0)
         {
             //실행문1 : 짝수일대
             Debug.Log("a는 짝수입니다");
         }
         else 
         {
             //실행문2 : 짝수가 아닌 나머지는 모두 홀수 
             Debug.Log("a는 홀수입니다");
         }
         //실행문 3
         Debug.Log("종료합니다");*/

        /*홀수 판별식
        
        if (a % 2 == 1)
        {
            Debug.Log("a는 홀수입니다");
        }
*/

        //입력받은 수가
        //3의배수. 5의배수, 7의배수 판별식 만들기 : {a}는 3,5,7의 배수
        //아니면 {a}는 3,5,7의 배수가 아니다

        /*if (a%3 == 0) // a를 3으로 나누었을떄 나머지가 0이다
        {
            //실행문1
            Debug.Log("{a}는 3의 배수");
        }
        else if (a%5 == 0) // a를 5으로 나누었을떄 나머지가 0이다
        {
            //실행문2
            Debug.Log("{a}는 5의 배수");
        }
        else if (a%7 == 0) // a를 7으로 나누었을떄 나머지가 0이다
        {
            //실행문3
            Debug.Log("{a}는 7의 배수");
        }
        else 
        {
            //실행문
            Debug.Log("{a}는 3,5,7의 배수가 아니다");
        }
            //실행문4
            Debug.Log("종료");*/


        if (a % 3 == 0) Debug.Log($"{a}는 3의 배수");
        if (a % 5 == 0) Debug.Log($"{a}는 5의 배수");
        if (a % 7 == 0) Debug.Log($"{a}는 7의 배수");
        if (a % 3 != 0 && a % 5 != 0 && a % 7 != 0) Debug.Log($"{a}는 3,5,7의 배수가 아니다");
        Debug.Log("종료");




    }

}
