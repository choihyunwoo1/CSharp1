using UnityEngine;

public class ForSome : MonoBehaviour
{
    public int n = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 n까지 합을 구하는 프로그램 구현

        /*                int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            //반복 실행문
            sum = sum + i;
       
        }
        Debug.Log($"합은: {sum}");                  */



        //1부터 20까지 정수중 짝수의 합을 구하는 프로그램 구현

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            //반복 실행문
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
            

        }
        Debug.Log($"1부터 {n}까지의 정수 중 짝수의 합은: {sum}");




    }

}
