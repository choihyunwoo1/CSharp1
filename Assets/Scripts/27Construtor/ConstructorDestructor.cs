using UnityEngine;

namespace constructor
{
    public class ConstructorDestructor : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //DestructorTest 클래스 인스턴스 생성
            DestructorTest test = new DestructorTest();

            //사용
            test.Run();

            //소멸: 가비지컬렉터(GC)가 알아서 해준다
            // ~DestructorTest();

        }
    }

}
/*
Destructor(소멸자)
: 클래스가 사용된 후 가장 마지막에 호출되는 메서드
: 생성된 인스턴스(객체)가 메모리상에서 없어질때 호출
: 이때 클래스에서 사용된 모든 메모리 해체 등을 처리
C#의 메모리 해제 : GC(가비지 컬렉터)가 메모리 해체 역할을 대신 한다

소멸자 형식

Class Car
{
    //소멸자 = 메서드
    ~Car()
    {
        //개체가 소멸할때 필요한 기능 수행
    }
}



 */