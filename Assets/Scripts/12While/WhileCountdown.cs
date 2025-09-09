using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    public int n = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //5부터 1까지 카운트다운 하는 감소 프로그램 구현
        int i = n;   //초기식

        while (i >= 1)  //조건식  
        {
            Debug.Log($"countdown: {i}");  //반복 실행문
            i--;     //증감식
        }

        Debug.Log("끊고");

        //1부터 5까지 카운트다운 하는 증가 프로그램 구현
        int j = 1;   //초기식

        while (j <= n)  //조건식  
        {
            Debug.Log($"countdown: {j}");  //반복 실행문
            j++;     //증감식
        }
    }

}
