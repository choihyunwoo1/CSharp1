using UnityEngine;

// string: 문자(배)열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언 및 초기화
        string arr = "C#8";

        /*Debug.Log(arr);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);
*/

        foreach (char c in arr)  //str=문자열  //float=실수형
                                 //char=문자형 //int = 문자형 //var=변수에 저장된 값에따라 형태변경 (만능)
        {
            Debug.Log(c);
        }  
    }

}


