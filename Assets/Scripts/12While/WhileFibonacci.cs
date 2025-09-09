using UnityEngine;

public class WhileFibonacci : MonoBehaviour
{
    //반복 횟수
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //초기식
        int first = 0, second = 1, i = 0;

        while (i < n)  //조건식
        {
            //반복 실행문
            Debug.Log(second);
            int temp = first + second;
            first = second;
            second = temp;

            //증감식
            i++;
        }

        ////////////////////////////////////////


        int count = 10; // 출력할 개수
        int a = 0;      // 첫 번째 값
        int b = 1;      // 두 번째 값

        Debug.Log("피보나치 수열 출력:");

        for (int i = 0; i < count; i++)
        {
            Debug.Log(a); // 현재 값 출력

            int temp = a + b; // 다음 값 계산
            a = b;           // b를 a로 옮김
            b = temp;        // 새 값으로 b 갱신
        }


    }

}
