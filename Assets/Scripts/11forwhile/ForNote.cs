using UnityEngine;

public class ForNote : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 1씩 증가하면서 증가한 값을 출력한다.
        //count:1, count:2 count:3 count:4 count:5

        /*for (int i = 0; i < 5; i++)
        {
            //반복 실행문
            Debug.Log($"count: {i+1}");
        }

        for (int i = 1; i <= 5; i++)
        {
            //반복 실행문
            Debug.Log($"count: {i}");
        }
        */

        //                      i가 2씩 증가
        for (int i = 0; i <= 5; i = i + 2 )
        {
            //반복 실행문
            Debug.Log($"count: {i}");
        }
    }

}
