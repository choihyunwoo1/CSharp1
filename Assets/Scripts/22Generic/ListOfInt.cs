using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//제네릭 리스트: 배열, 제네릭 리스트 비교
public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 사용
        //정수형 배열 선언하고 요소수 생성
        int[] arrNumbers = new int[2];
        //배열 변수 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        //배열 사용
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }   

        //제네릭 리스트 사용
        // List<T> : int 전용의 제네릭 리스트 인스턴스 생성
        List<int> listNumbers = new List<int>();
        //리스트에 데이터 추가
        listNumbers.Add(30);
        listNumbers.Add(40);
        listNumbers.Add(50);
        //리스트 사용
        for (int i = 0; i < listNumbers.Count; i++)  //count3
        {
            Debug.Log(listNumbers[i]);
        }

        listNumbers.Add(60);
        for (int i = 0; i < listNumbers.Count; i++)  //count4
        {
            Debug.Log(listNumbers[i]);
        }
        //리스트 사용은 배열처럼 사용한다.
        // Queue, Stack, List = count (넣으면 넣을수록 커지는 무한대의 저장소)
        // 배열[] = Length (처음 생성할때부터 프로그램 종료떄까지 처음 지정한만큼의 길이{불변X})

    }   
}
