using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 생성
            Person person = new Person();

            //private한 필드
            // Person.name = "홍길동"; - 보호수준 에러

            //속성 이용하여 private 필드 쓰고 읽기
            person.Name = "홍길동";
            Debug.Log(person.Name);

            //메서드 이용하여 private필드 쓰기읽기
            person.SetName("백두산");
            Debug.Log(person.GetName());

        }
    }

}
