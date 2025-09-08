using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//만약 score가 60이상이면 "합격" 이라고 출력
public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 60;
 
        //만약 조건식이 참이면 { } 안에있는 실행문을 실행하라
        //if( Score 60 이상)
        if (score >= 60) 
        {
            //"합격" 이라고 출력
            Debug.Log("합격");
        }

        //단문(실행문이 1개), 복문(실행문이 2개 이상)
        if( 1 == 1 )
        {
            Debug.Log("단문 1");
        }

        // if문에서 {}이 생력되면 if문 밑에 있는 명령문을 참일때 실행
        // if문 바로 밑에 있는 명령문 하나만 if문 실행문이 된다
        if (1 == 1)
            Debug.Log("단문 2");

        //한줄로도 단축 가능
        if (1 == 1) Debug.Log("단문 3");


        //복문(실행문 2개 이상) 일때는 무조건 {}코드블럭이 있어야 함
        if (1 == 1)
        {
            Debug.Log("복문 1");
            Debug.Log("복문 2");
            //...
        }
    }

}

/* 조건문
 
 if(조건문) : 조건식이 참일때만 실행문이 실행됩니다.
(조건문이 거짓이면 실행문을 실행하지 않습니다)

만약 조건식이 참이면 {} 안에있는 실행문을 실행하라 = 실행하기 위해선 조건식이 참이 나와야함
-
if(조건식)           
{
  //실행문1
  //실행문2
  //...
}
=
if(bool)
{
  //실행문1
  //실행문2
  //...
}


 */