using UnityEngine;

public class WhileSum : MonoBehaviour
{
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


   {
         /*int sum = 0;

         int i = 1;   //초기식

         while (i <= n)  //조건식  
         {
             sum = sum + i; //반복 실행문
             i++;  //증감식
         }
         Debug.Log(sum);*/
     

        //1부터 100(n)까지의 정수중 짝수의 합을 출력하는 프로그램 구현

        int sum = 0; //합을 지정하는 변수

        int i = 1;   //초기식

        while (i <= n)  //조건식  
        {
            //반복 실행문 - 짝수의 합
            if (i % 2 == 0) //판별식
            {
                sum = sum + i; 
            }
            i++;  //증감식
        }
        Debug.Log($"1부터 n까지의 정수중 짝수의 합: {sum}");
    }

}

/*
  While문을 이용해서 1부터 100(n)까지 합을 구하는 프로그램 구현
 */