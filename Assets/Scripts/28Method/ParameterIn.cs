using UnityEngine;

namespace Method
{
    public class ParameterIn : MonoBehaviour
    {

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정수형 변수 num 선언 후 초기화
            int num = 10;
            Debug.Log($"[1]: {num}");   //10 [1]
             
            PrintNumber( num );        //num 을 PrintNumber로 옮김

            Debug.Log($"[1]: {num}");   //10 [2]
        }

        private void PrintNumber(int num)  //private 생략 가능
        {
            num = 20;
            Debug.Log($"[2]: {num}");   //20 [3]
        }
    }
            //출력순서는  [1] - [3] - [2] 순서 
}
/*
매개변수(Parameter) - 함수의 값을 전달하는 역할
- 전달되는 방법에 따라 구분
[1] : 값 전달 방법 - (int num)
[2] : 참조 전달 방법 - (ref int num)
[3] : 반환형 전달 방법 - (out int num)
[4] : 가변형 전달 방법 - (params int[] numbers)
 */