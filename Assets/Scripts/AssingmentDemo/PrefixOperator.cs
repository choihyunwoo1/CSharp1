using UnityEngine;

//전위 증감 연산자 : 같은 라인에서 연산하는 우선순위가 가장 높다 (가장 먼저 연산)
//후위 증감 연산자 : 
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //전위 증감 연산자
        int i = 3;
        int j = ++i;
        Debug.Log($"j: {j}");  // j = 4

        //후위 증감 연산자
        int x = 3;
        int y = x++;             // y = 4
        Debug.Log($"x: {x}");   // x = 4
        Debug.Log($"y: {y}");  // y = 3






    }


}
