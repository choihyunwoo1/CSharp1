using UnityEngine;


public class IntParse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1.문자를 숫자로 형식변환

        string strNumber = "1234";
        //숫자를 가지고 있는 문자 선언
        
        int number1 = System.Convert.ToInt32(strNumber);
        Debug.Log($"{number1} - {number1.GetType()}");
        
        int number2 = int.Parse(strNumber);
        Debug.Log($"{number2} - {number2.GetType()}");

        int number3 = System.Int32.Parse(strNumber);
        Debug.Log($"{number3} - {number3.GetType()}");



    }

    
}
