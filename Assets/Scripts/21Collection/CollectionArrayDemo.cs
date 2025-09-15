using UnityEngine;

public class CollectionArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //컬렉션(배열) 선언,요소수 생성
        string[] colors = { "red", "green", "blue" };  
        
        Debug.Log($"배열의 요소의 갯수: {colors.Length}");

        for (int i = 0; i < colors.Length; i++)
        { 
            Debug.Log(colors[i]);   
        }

    }
}
/*
 
  Variable(변수) : 하나의 이름으로 데이터를 저장하는 그릇

  Array(배열) : 하나의 이름으로 같은 형식,같은 크기 데이터 여러개를 담는 그릇이다 , 변수 확장

  Collection(컬렉션) : 배열처럼 특정 항목 데이터를 묶어서 관리하는 것을 컬렉션 이라고 한다.
  :배열, 리스트, 딕셔너리(사전)을 사용하여 관련 객체의 그룹을 만들고 관리 

  Structure(구조체) : 하나의 이름으로 서로다른 형식의 데이터, 함수들을 묶어 관리하는 그릇

  Class(클래스) : 하나의 이름으로 서로 다른 형식의 데이터들, 함수들을 묶어 관리하는 그릇
  : 사용자 정의 데이터 형식

 */