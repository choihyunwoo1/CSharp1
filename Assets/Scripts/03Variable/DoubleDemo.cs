using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 만들기(선언) 및 초기화
        float f = 3.14F;
        double D = 3.14;
        decimal m = 3.14M;

        float min = float.MinValue;
        float max = float.MaxValue;

        //변수 사용
        Debug.Log(f); 
        Debug.Log(D);
        Debug.Log(m);

        Debug.Log(min);
        Debug.Log(max);

    }

}

/*
 실수형 데이터 형식
1.Float   : 32Bit  부동 소수점 숫자
2.Double  : 64Bit  부동 소수점 숫자
3.Decimal : 128Bit 부동 소수점 숫자


 */