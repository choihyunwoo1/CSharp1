using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1.2 변수선언과 동시에 값 대입(초기화)
        int number = 7;
        //3.변수에 들어있는 값을 사용하기(참조)
        Debug.Log(number);
    }
}
