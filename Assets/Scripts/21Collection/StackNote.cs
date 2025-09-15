using UnityEngine;
using System.Collections;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //[1] Stack 클래스의 객체(개체, 인스턴스)생성
        Stack stack = new Stack(); //우물 생성

        //[2] 데이터 입력
        stack.Push("대한민국");
        stack.Push("경기도");
        stack.Push("수원");

        //[3] 데이터 사용
        Debug.Log(stack.Count); //우물에 들어있는 데이터의 갯수
        Debug.Log(stack.Peek()); //가장 마지막에 들어간 데이터 읽어들이기
        Debug.Log(stack.Pop()); //데이터 출력
        Debug.Log(stack.Pop()); //데이터 출력

        //[4] 사용 전에 카운트체크
        if (stack.Count > 0)
        {
            Debug.Log($"{stack.Count}");
        }

        //[5] 스택 비우기
        stack.Clear();
        Debug.Log($"{stack.Count}");
 

    }
}
