using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]: Queue 클래스의 인스턴스(객체, 개체) 생성
        Queue queue = new Queue();

        //[2]: 
        queue.Enqueue(123);
        queue.Enqueue(456);
        queue.Enqueue(789);

        //[3]:
        Debug.Log(queue.Dequeue());  //123
        Debug.Log(queue.Dequeue());  //456

        // 맨 앞 확인만 (Peek)
        Debug.Log(queue.Peek());  //789

        //비우고 카운팅
        queue.Clear();
        Debug.Log($"{queue.Count}");
    }
}
/*
  Queue(큐) 클래스 : FIFO( First In First Out, 선입선출 )형태로 데이터를 저장 관리하는 클래스
  = 먼저 들어간놈이 먼저 나온다 = 대기 번호표 시스템
  = 터널형 창고

  Enqueue() : 큐 데이터 구조에 데이터 입력, 저장
  Dequeue() : 큐 데이터 구조에서 데이터 꺼내기
  Peek() : 우물의 맨위 상단에 있는 데이터 읽어오기(꺼내오는 것이 아님) = 제일 마지막에 들어온 데이터 읽기  
  Clear() : 쌓인 스택 초기화
  Count : 스택 구조에 들어있는 데이터의 갯수


 */