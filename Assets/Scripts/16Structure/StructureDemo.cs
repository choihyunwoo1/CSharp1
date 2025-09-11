using UnityEngine;

// 1. 구조체 정의, 선언
//두개의 정수를 관리하는 구조체
struct point
{ 
    public int x, y;  // public: 키워드로 외부에서 int x,y변수를 사용 가능하도록 설정
    
}


public class StructureDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2.구조체 형식의 변수선언: point 구조체 형식의 변수 선언
        point p;

        //3. x, y의 변수에 값을 초기화한다(대입)
        p.x = 100;
        p.y = 200;

        //4. 사용
        Debug.Log($"x: {p.x},y: {p.y} ");

    }

}
/*
  Variable(변수) : 하나의 이름으로 데이터를 저장하는 그릇
  Array(배열) : 하나의 이름으로 같은 형식,같은 크기 데이터 여러개를 담는 그릇이다 , 변수 확장
  Structure(구조체) : 하나의 이름으로 서로다른 형식의 데이터, 함수들을 묶어 관리하는 그릇 
  
//구조체 정의, 선언
struct (구조체 이름)
{
    //서로 다른 형식의 데이터들..
    //함수들...
}






 
 */