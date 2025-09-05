using UnityEngine;

// +더하기 연산 추가 가능
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("Hello" + "World");  //문자열 더하기
                                      //문자열에선 빼기라는 것이 없음

        Debug.Log("123" + "456");   // " 안에 들어가면 전부 문자로 치환됨 (숫자아님)
                                   //즉 문자열 + 문자열

        Debug.Log("123" + 456);  // 문자열 + 숫자 : 문자열 (데이터값이 높은쪽으로 치환됨)

        Debug.Log("123" + true);  // 문자열 + bool : 문자열 (데이터값이 높은쪽으로 치환됨)



        Debug.Log(123 + 456);  // 숫자 + 숫자 : 산술연산

        Debug.Log(123 + 456 + 789 + "890"); // 숫자 + 문자열 +숫자 +숫자 : 문자열
                                            


      





    }

   
}
