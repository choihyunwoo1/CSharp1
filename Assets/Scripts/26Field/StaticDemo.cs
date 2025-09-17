using UnityEngine;

namespace field
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Truck 클래스의 정적(Static) 멤버 사용하기
            //클래스이름.정적멤버이름 접근해서 사용한다
            Truck.name = "홍길동";
            string tName = Truck.GetName();
            Debug.Log(tName);

            // Truck.age = 20; - 불가능 : 인스턴스 멤버라 클래스 네임으로 접근 불가 and Private

            //Truck 클래스의 인스턴스(Instance) 멤버 사용하기
            //Truck 클래스의 인스턴스(Instance) 생성
            //생성된 인스턴스(Instance)이름.인스턴스멤버이름 으로 접근해서 사용한다
            Truck truck = new Truck();
            // truck.age = 20; - 보호수준 에러 (Private)
            truck.SetAge(20);
            Debug.Log(truck.GetAge());
            


        }
    }

}
