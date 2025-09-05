using UnityEngine;

public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //정수형 변수의 값을 1씩 증가
        //1. 변수 선언 및 초기화
        int num = 10;
        num = num + 1; 
        Debug.Log(num); //결과는 11

        //2.정수형 변수의 값을 1씩 감소하는 식
        int number = 10;
        number = number - 1;
        Debug.Log(number); //결과는 9

        //3.축약해서 사용하기
        int x = 10;
        //x = x + 1;
        x += 1;  // 1씩 증가하는 누적식 (축약)
        Debug.Log(x);
        int a = 3;
        int b = 5;
        b -= a; //a씩 감산 누적식
        Debug.Log($"b: {b}");

        /*//실험
        x =+ 1;
        Debug.Log(x);   // x가 1로 재선언됨
*/

    }


}
