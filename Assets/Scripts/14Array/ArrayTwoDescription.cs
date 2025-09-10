using UnityEngine;

public class ArrayTwoDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2차원 배열 선언, 첫번째 요소수만 생성
        int[][] intArray = new int[2][];
        //[0][1]
        //두번쨰 요소수를 각각 따로 생성한다, 초기화
        intArray[0] = new int[3] { 1, 2, 3 };  //[0]번행에 3개의 열을 생성
        intArray[1] = new int[2] { 4, 5 };    //[0]번행에 2개의 열을 생성

        //배열의 길이
        Debug.Log($"배열의 길이: {intArray.Length}");

        //배열의 요소들 출력 : {intArray[0].Length}   {intArray[1].Length}
        for (int i = 0; i < intArray.Length; i++) 
        {
            for (int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log($"intArray[{i}][{j}]: {intArray[i][j]}");
            }
            Debug.Log("====================");
        }
       
    }

}
