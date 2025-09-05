using UnityEngine;

// ++증가 연산자: 정수형 변수의 값을 1씩 증가
// --감소 연산자: 정수형 변수의 값을 1씩 감소
public class incrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 100;

        // 1씩 증가하는 증가식
        //num = num + 1;
        //num += 1;
        ++num;           //셋 다 1씩 증가함
        Debug.Log($"num: {num}");

        //1씩 감소
        num = -100;
        //num = num -1;
        //num -= 1;
        --num;
        Debug.Log($"num: {num}");


    }

}

