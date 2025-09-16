using UnityEngine;
using Bar;
using Foo;

public class NamespaceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*    //[1] Bar 네임스페이스 Car 클래스 인스턴스 생성
            Bar.Car barcar = new Bar.Car();
            barcar.Go();

            //[2] Foo 네임스페이스 Car 클래스 인스턴스 생성
            Foo.Car foocar = new Foo.Car();
            foocar.Go();

            Car car = new Car(); //Bar 의 Car인지 Foo의 Car인지 모름
        */

        


    }
}
/*
   NameSpace(네임스페이스) : 클래스 등의 사용자 정의 형식들의 이름 충돌 방지
   클래스 등을 관련 기능끼리 묶어서 관리
   
namespace 네임스페이스 이름
{

}

 */