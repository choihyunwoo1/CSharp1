using UnityEngine;

//Operator(연산자): +, -, *, / 등의 연산을 진행하는 키워드
public class operatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Debug.Log(3 + 5);  //결과는: 8
        Debug.Log(3 - 5);  //결과는: -2
        Debug.Log(3 * 5);  //결과는: 15
        Debug.Log(3 / 5);  //결과는: 0
        */

        /*int value = 0;

        value = 8;   //value라는 변수에 8을 저장한다 라고 설명됨
        value = +value;  // 왼쪽의 value는 저장  오른쪽의 value는 참조 즉 불러오는 역할 
        Debug.Log(value);  // 8

        value = -8;
        value = +value;  // -8
        Debug.Log (value);

        value = 8;
        value = -value;  // -8
        Debug.Log (value);  

        value = -8;
        value = -value;  // 8
        Debug.Log (value);*/

        int i = 5;
        int j = 3;
        int k;

        k = i + j;   // 8
        Debug.Log(k);

        k = i - j;   // 2
        Debug.Log(k);

        k = i * j;   // 15
        Debug.Log(k);

        k = i / j;   // 1
        Debug.Log(k);

        k = i % j;   // 2
        Debug.Log(k);










    }


}

/*
단항 연산자 : +, - (부호)
이항 연산자 : +, -, *, /, % 
심항 연산자 : 
 */