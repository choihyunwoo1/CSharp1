using UnityEngine;

// string(문자열) 데이터 형식

public class StrDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //1.string 변수 선언 및 초기화
        string name = "홍길동";
        string muliline = @"
                안녕하세요
                반갑습니다
        ";


        //2.사용하기
        Debug.Log("안녕하세요 " + name + "입니다" );
        Debug.Log ( muliline );
        */

        //문자열 보간법 (string Interpolation)

        //1.변수 선언
        string message = "문자열 보간법";
        string msg = string.Format("{0}님 {1}", "홍길동" , "안녕하세요");

        //2.사용하기
        Debug.Log("Message: " + message); //문자열 더하기 연산
        Debug.Log($"Message: {message}"); //문자열 보간법
        Debug.Log(msg);

        
    }

   
}
