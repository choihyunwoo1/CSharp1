using UnityEngine;

namespace Method
{
    public class MethodDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Rectangle 클래스의 인스턴스 생성
            Rectangle rectangle = new Rectangle();
            Debug.Log(rectangle.GetName());
            
        }
    }

    public class Rectangle
    {
        //메서드
        public string GetName()
      // = 접근제한자, 정적X, 반환O(string), 메서드이름(매개변수X)
        {
            return "정사각형";
        }
    }

}

/*
메서드(Method), 함수(Function)
: 클래스가 수행할수 있는 기능들을 각각 다른 이름으로 묶어서 관리(구현) 하는 코드블록
ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
형식
   접근 제한자       정적          반환여부          메서드 이름 (데이터 타입)
(public/private) static(o/x) void(int, string....) 메서드이름(매개변수)
{
    //메서드의 실행문들

    //return 반환타입 
}
ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
코딩 스타일
메서드 이름 : 이름의 첫 글자는 대문자로 쓴다
: 동사 + 명사
~를 가져온다 (읽기): Get(Name, Hp, Age, etc....)
~를 사용한다 (쓰기): Set(매개변수로 내가 사용할 내용 {ex) "홍길동", 1234..... }) 











 */