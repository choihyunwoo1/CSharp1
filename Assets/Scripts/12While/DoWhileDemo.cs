using UnityEngine;

public class DoWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요 3회 출력 프로그램

        /* 
        for (int j = 0; j < n; j++)  //초기식+조건식+증감식
        {
            Debug.Log("안녕하세요");  //반복 실행문
        }                                                                초기식 ㅡ조건식 ㅡ증감식 ㅡ 실행문
        Debug.Log("for식"); 

        ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
        
        int i = 0;   //초기식

        while (i < n)  //조건식  
        {
            Debug.Log("안녕하세요");  //반복 실행문                        초기식 ㅡ 조건식 ㅡ 실행문 ㅡ증감식
            i++;     //증감식
        }
        Debug.Log("while식");

        */

        //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

        int i = 0; //초기식

        do
        {
            Debug.Log("안녕하세요");  //반복실행문
            i++;  //증감식                                                초기식 ㅡ 실행문 ㅡ증감식 ㅡ조건식
        } while (i < 3); //조건식

        Debug.Log("Dowhile식");

    }
}

/*
// Dowhile문
//반복 실행문을 실행
//조건식 판별하여 참이면 반복 실행문 실행
//거짓이면 while문 종료
//무조건적으로 반복실행문을 1회 실행

do
{
   //반복 실행문
} while(조건식)


 */
