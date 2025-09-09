using System;
using UnityEngine;

public class ForTriangle : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        for (int i = 1; i <= 5; i++)
        {
            //반복 실행문
            for (int j = 1; j <= 5; j++)
            {   
                //반복 실행문
                Debug.Log($"i:{i},j:{j}");
            }
        }

       //////////////////////////////////////////////////////


        for (int i = 1; i <= 5; i++)
        {
            //반복 실행문
            for (int j = 1; j < i; j++)
            {
                //반복 실행문
                Debug.Log(j);
            }
            Debug.Log("==========================");
        }

        ///////////////////////////////////////////////////////////*/
       

        for (int i = 1; i <= 5; i++)
        {
            //반복 실행문
            for (int j = 1; j < 5; j++)
            {
                //반복 실행문
                Console.Write("*");
            }
            Console.WriteLine();
        }



    }
}

/*
 2중(다중) For문
i...j...k...l...

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            ......for문 중첩 가능
        }
    }

 */