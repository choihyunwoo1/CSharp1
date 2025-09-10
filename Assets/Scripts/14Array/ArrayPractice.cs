using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* int[,] intArray; intArray = new int[3, 3];

         for (int i = 0; i < 2; i++) 
         {
             for (int j = 0; j < 3; j++) 
             {
                 if (i == j)
                 {
                     Debug.Log(intArray);
                 }
                 Debug.Log(intArray);

             }

         }    */

        int[,] intArray = new int[3, 3]; // 3행 3열 배열 생성

        for (int i = 0; i < intArray.GetLength(0); i++) // i: 행
        {
            for (int j = 0; j < intArray.GetLength(1); j++) // j: 열
            {
                if (i == j)
                    intArray[i, j] = 1; // 행과 열 같으면 1
                else
                    intArray[i, j] = 0; // 아니면 0

                Debug.Log($"intArray[{i}, {j}]: {intArray[i, j]}");
            }

            
        }

    }

}
/*
 3행 3열의 2차원 배열을 만들고 아래와 같이 초기화 해주세요
[ 3, 3 ]

행과 열이 같으면 1, 행과 열이 틀리면 0으로 초기화 
 
 */