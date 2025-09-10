using UnityEngine;

// 2차원 배열 : 행과 열로 이루어진 배열
// (데이터 타입) [행,열] int array
public class ArrayTwoDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열 선언
        int[,] intArray;

        //[2] 배열 요소수(크기) 생성
        intArray = new int[2, 3];  //<행이 0,1> <열이 0,1,2>

        //[3] 배열 초기화
        intArray[0, 0] = 1; //0번행에 0번열이라는 인덱스에 1이라는 값을 기입
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;

        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;
       

        //[4] 배열 사용
        for (int i = 0; i < 2; i++) //i=1
        {
            for (int j = 0; j < 3; j++) //j=0,1,2
            { 
                Debug.Log(intArray[i, j]);
            }
            Debug.Log("==========================");
        }
   
    }
        
}
