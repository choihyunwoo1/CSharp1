using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

//배열로 값을 모아놓고 원하는 값을 원하는대로 뽑기
public class LinQCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //불형 배열 변수 선언 및 요소수 생성
        bool[] bins = { true, false, true, false, true};

        //전체 요소수의 갯수
        Debug.Log(bins.Count());  // 전체 값의 갯수

        //true의 갯수가 몇개인지
        Debug.Log(bins.Count(n => n == true));  // (n => n == true) : 람다식

        //false의 갯수 구하기
        Debug.Log(bins.Count(a => a == false));

        
    }
}
/*
  
 */