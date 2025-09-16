using UnityEngine;

//개체, 객체(오브젝트) 인스턴스 : 설계도인 클래스로부터 만들어진 하나의 인스턴스(실체, 구성 요소)

//[1] ClassCode 이름의 클래스(Class) 만들기
public class ClassCode
{ 
    //Empty
}

public class ClassAndObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 특정 클래스(ClassCode)의 개체(오브젝트) 만들기 = 인스턴스 생성
        //ClassCode 인스턴스를 objectCode1 라는 이름으로 생성
        ClassCode objectCode1 = new ClassCode();
        Debug.Log(objectCode1.GetHashCode()); //GetHashCode : 인스턴스(객체,오브젝트)의 고유코드 보기

        //ClassCode 인스턴스를 objectCode2 라는 이름으로 생성
        ClassCode objectCode2 = new ClassCode();
        Debug.Log(objectCode2.GetHashCode());


    }
}
