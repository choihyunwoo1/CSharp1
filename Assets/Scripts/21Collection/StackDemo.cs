using UnityEngine;
using System.Collections;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack 클래스의 객체(개체, 인스턴스)생성
        Stack stack = new Stack(); //우물 생성

        //[2] 데이터 입력
        stack.Push("첫번째");
        stack.Push("두번째");
        stack.Push("세번째");

        //[3] 데이터 꺼내기
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        try 
        {
            Debug.Log(stack.Pop());
        }
        catch(System.Exception ex) 
        {
            Debug.Log($"에러내용 출력: {ex.Message}");
        }
    }
}
/* 
  Stack 클래스 : LIFO( Last In First Out, 후입선출 )형태로 데이터를 저장 관리하는 클래스
  = 나중에 들어간놈이 먼저 나온다
  
  Count : 스택 구조에 들어있는 데이터의 갯수
  Push() : 스택 구조에 데이터 입력
  pop() : 스택 구조에 데이터 출력 = 꺼내온 데이터는 제거됨
  Peek() : 우물의 맨위 상단에 있는 데이터 읽어오기(꺼내오는 것이 아님) = 제일 마지막에 들어온 데이터 읽기  
  Clear() : 쌓인 스택 초기화

  Overflow : 스택이 가득 찼을때 채울려고 하면 발생하는 에러
  Underflow : 스택이 비어있을때 데이터를 꺼낼려고 하면 발생하는 에러

 */
