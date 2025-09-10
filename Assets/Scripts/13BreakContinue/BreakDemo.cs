using Unity.VisualScripting;
using UnityEngine;

public class BreakDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int i = 0;
        int sum = 0;

        while (true)   //무한 반복
        { 
            sum = sum + i;   //반복 실행문
            if (sum >= 22)  //22이상되면 더이상 반복하지 않는다
            {
                break;
            }
            i++;  //증감식
        }
        Debug.Log(sum);*/  


        int i = 1;    // 1부터 시작
        int sum = 0;

        while (i <= 10 && sum < 22)  // 10까지 반복, 합이 22 미만일 때만
        {
            sum += i;   // sum = sum + i;
            i++;
        }

        Debug.Log(sum);

    }

}
/*
1부터 10까지의 정수의 합(sum)을 구하는 프로그램 구현
합(sum)이 22이상이 되면 더이상 합을 구하지 않는다.
    while문 이용
    sum출력
*/