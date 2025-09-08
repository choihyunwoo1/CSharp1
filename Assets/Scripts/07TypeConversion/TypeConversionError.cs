using UnityEngine;

//
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* //1.long 형식 변수 선언하고 가장 큰 수를 저장
         long l =long.MaxValue;
         Debug.Log($"l의 값: {l}");

         // 2. int 형식의 변수에 i값을 저장 (형 변환)
         int i = (int)l;
         //int는 대략 플마 21억까지만 저장 가능(담을 수 없음)
         Debug.Log($"i의 값 : {i}"); */

        int x = 255;
        //(21억 단위까지 저장가능)
        byte y = (byte)x;
        //(0에서 255까지 저장가능)
        Debug.Log(x + "->" + y);
        //( 255->255 가 출력되지만 앞의건 int형 255 뒤에건 byte형 255이다 )







    }

   
}
