using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;  // o도 1234를 직접 복사
        Debug.Log(o);

        object obj = 4321;
        int number = (int)obj;  //캐스팅(형변환)
        Debug.Log(number);

        object s = "안녕하세요";
        object j = 9871;

        if (s is string)  // s가 string형식으로 변환이 가능한가? (true/false)
        { 
            Debug.Log($"[1] {s}는 null이 아니며, 문자열 형식으로 변환이 가능하다.");
        }
        if (j is int)
        {
            Debug.Log($"[1] {j}는 null이 아니며, 정수형으로 변환이 가능하다.");
        }

    }
}
/*
  그릇의 형식
  [1].값 형식(Value Type) : 개체에 값 자체를 담고 있는 구조
  int, float, bool, struct 등...

  [2].참조 형식(Reference Type) : 개체가 값을 담고있고 또 다른 개체가 포인터로 바라보는 구조 
  new라고 그릇을 만들고 데이터를 담을 경우
  class, string, array, List<T> 등...

[1].값 형식 = "사과를 직접 들고 있다" → 복사하면 서로 독립

[2].참조 형식 = "사과 창고의 주소를 들고 있다" → 복사해도 같은 창고를 바라봄

  박싱(Boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는 것
  언박싱(UnBoxing) : 참조 형식의 데이터를 값 형식의 데이터로 변경하는 것 - (캐스트, 캐스팅)
  
 Is 연산자 : 형식을 비교하기
 : 특정 데이터 형식인지 아닌지를 비교
 : 특정 데이터 형식으로 변환(캐스팅)이 가능하면 true, 그렇지 않으면 false로 리턴한다
   
 */