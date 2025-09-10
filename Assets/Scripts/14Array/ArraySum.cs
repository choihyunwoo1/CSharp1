using System;
using UnityEngine;

public class ArraySum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 요소들의 모든 값의 총합을 구하는 프로그램
        float[] arr = { 10.5f, 20.1f, 30.3f, 40.5f };

        //합을 저장하는 변수 선언
        float sum = 0;

        Debug.Log(arr.Length);   // arr.Length = 알아서 저장된 변수의 갯수를 넣어줌

        /*for (int i = 0; i < arr.Length; i++)  //귀찮다면 foreach문을 사용
        { 
            sum=sum+arr[i];        
        }*/

        foreach (var item in arr)
        {
            sum += item;
        }

            Debug.Log(sum);


        // index를 사용할려면 for문(i를 0번부터 사용)을 사용하는게 좋음
        // 배열의 값을 가지고 무언가 할려면 foreach문을 사용하는 것이 좋음

    }

}
