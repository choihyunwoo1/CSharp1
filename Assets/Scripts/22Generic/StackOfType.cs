using UnityEngine;
using System.Collections.Generic;

public class StackOfType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack<T> 클래스 인스턴스 생성 
        // Stack<string> : <string> 전용 Generic 클래스 인스턴스 생성
        Stack<string> stack = new Stack<string>();  //- 문자열 전용

        //[2] 데이터 넣기, 저장, Push()
        //문자열 전용 제너릭 클래스라고 지정 해 놓아기에 메서드는 문자열 입력만 가능
        stack.Push("TEN");
        stack.Push("10");

        //[3] 데이터 사용
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        //이때 10,TEN 순서대로 출력 = 스택형이라 후입선출형으로 마지막에 들어간 값부터 출력됨.
    }
}

/*
  Generic(제네릭) 클래스 : 형식 매개변수 T로 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
  Generic Class : Cup<T> 컵오브티, 전용컵
    
 */