using UnityEngine;

// RealationalOperator(관계 연산자,비교 연산자)
// < (작음), <= (작거나 같음), > (큼), >= (크거나 같음), == (같음), != (다름)
// 결과 : true(참), false(거짓) , 즉 연산결과를 Bool(부울형)으로 처리함
public class RealationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);      // x(3)는 y(5)보다 작으냐?        // true
        Debug.Log(x <= y);    // x(3)는 y(5)보다 작거나 같으냐?  // true
        Debug.Log(x > y);     // x(3)는 y(5)보다 크냐?          // false
        Debug.Log(x >= y);   // x(3)는 y(5)보다 크거나 같으냐?  // false
        Debug.Log(x == y);   // x(3)는 y(5)와 같냐?           // false
        Debug.Log(x != y);  //  x(3)는 y(5)와 다르냐?        // true

        Debug.Log("ㅁㅁㅁ" == "aaa"); //형식으로 사용가능
    }

}
