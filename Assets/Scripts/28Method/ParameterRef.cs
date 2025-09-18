using UnityEngine;

namespace Method
{
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1]: {number}");  //10

            PrintNumber(ref number);

            Debug.Log($"[3]: {number}");  //20
        }

        //정수형 변수 num을 (ref)레퍼런스 매개변수로 입력받아 출력하는 메서드
        void PrintNumber(ref int number)
        {
            number = 20;
            Debug.Log($"[2]: {number}");  //20
        }

    }

}

/*
 참조 전달 방법 - (ref int num)
 */