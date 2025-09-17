using UnityEngine;

namespace Field
{
    public class FieldPublicPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Car 클래스의 인스턴스 생성
            Car mycar = new Car();

            //[2] Car 클래스에 있는 public 필드 접근해서 사용(읽기, 쓰기)이 가능하다
            mycar.name = "홍길동";
            Debug.Log(mycar.name);

            //[3] Car 클래스에 있는 private 필드에 접근해서 사용 - 접근 불가
            // mycar.age = 20;
            // mycar.address = "서울"; 

            //[4] Car 클래스에 있는 public 메서드에 접근해서 사용
            mycar.Hi();

            //[5] Car 클래스에 있는 private 메서드에 접근해서 사용
            // mycar.Bye(); - 접근 불가

            //[6] Car 클래스에 있는 private 필드 age에 접근해서 사용하고 싶다.
            // Car 클래스에 age 필드 읽고 쓰는 public한 메서드를 만들어서 사용한다
            // mycar.age = 20; - 보호수준 에러
            // Debug.Log(mycar.age); -보호수준 에러
               mycar.SetAge(20);
               int myAge= mycar.GetAge();
               Debug.Log(myAge);
        }
    }
}