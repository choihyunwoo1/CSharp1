using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2]; //2개의 인덱스 생성
            arr[100] = 5; //범위를 벗어난 인덱스 
        }
        catch  //try에서 오류(Exception) 발생시 catch() 실행 
        {
            Debug.Log("에러가 발생했습니다");
        }




    }
}
/*
  예외 처리(Exceptionb Handling) : 프로그램에서 “처리할 수 있는 오류"
  
  //에러, 오류 종류
 - 문법 오류
 - 런타임 오류
 - 알고리즘 오류
    
  예외 처리 (try - catch)문
try
{
    //명령문....
}
catch
{
    //명령문 실행중 예외(Exception) 발생할때만 처리할 내용
    //....
}
 */