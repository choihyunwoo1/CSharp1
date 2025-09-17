using UnityEngine;

namespace constructor
{
    public class ConstructorOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ConstructorLog 클래스에 인스턴스 생성
            ConstructorLog log1 = new ConstructorLog();  //기본 생성자를 호출하여 인스턴스 생성
            ConstructorLog log2 = new ConstructorLog("홍길동"); //매개변수 string이 있는 생성자를 호출하여 인스턴스를 생성
            ConstructorLog log3 = new ConstructorLog("백두산"); //매개변수 string이 있는 생성자를 호출하여 인스턴스를 생성


        }

    }
}
