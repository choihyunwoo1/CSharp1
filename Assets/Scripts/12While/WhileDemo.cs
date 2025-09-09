using UnityEngine;

public class WhileDemo : MonoBehaviour
{
    public int n = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // '안녕하세요"를 n번 반복출력하는 프로그램

        for (int j = 0; j < n; j++)  //초기식+조건식+증감식
        {
            Debug.Log("안녕하세요");  //반복 실행문
        }
        Debug.Log("for식");

        ////////////////////////////////////////////

        int i = 0;   //초기식

        while (i < n)  //조건식  
        {
            Debug.Log("안녕하세요");  //반복 실행문
            i++;     //증감식
        }
        Debug.Log("while식");

    }

}

/*
//조건식이 true이면 반복 실행문을 실행
//조건식이 false이면 while문을 종료한다
//조건식 true, false 
 
While(조건식)
{
  //반복 실행문
}

조건식 판별(참) ㅡ> 반복 실행문 실행 ㅡ> 조건문 판별(참) ㅡ> 반복문 실행...(무한반복)
조건식 판별(거짓) ㅡ> while문 종료

==무한반복
while( true )
{  
    //반복 실행문
}
 */