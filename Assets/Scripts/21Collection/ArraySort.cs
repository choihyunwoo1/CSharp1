using UnityEngine;

public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // System 네임스페이스 Array 클래스에서 제공하는 함수들

        //배열의 정령(sort)
        int[] arr = { 3, 2, 1, 4, 5 };

        //sort - 오름차순: 0,1,2,3.... (문자는 사전기준)
        System.Array.Sort(arr);

        foreach (int i in arr)
        { 
            Debug.Log(i);
        }

        Debug.Log("==================================");

        //배열의 역순 : 지금 정렬되어 있는 순서를 거꾸로 정렬
        System.Array.Reverse(arr);

        foreach (int i in arr)
        {
            Debug.Log(i);
        }

        //ConvertAll: 문자열 배열을 정수형 배열로 형변환
        string[] strArray = { "10", "20", "30" };  //문자열이라 감산불가
        int[] intArray = System.Array.ConvertAll(strArray, int.Parse);

        foreach (int i in intArray)
        {
            Debug.Log(i);
        }


    }

}
