using UnityEngine;

namespace Method
{
    public class MethodPublicPrivate : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Dog 클래스의 인스턴스(객체) 생성
            Dog cat = new Dog();

            //인스턴스 메서드 사용방법
            //인스턴스이름.(public)함수이름 으로 호출
            cat.Eat();  //public 이라서 밖에서 호출 가능 
          //cat.Digest();  //private 라서 밖에서 호출 불가능
            
            //정적(Static) 메서드 사용방법
            //클래스이름.정적함수이름 이름으로 호출
            Dog.Drink();

            //외부에서 편하게 사용하기 위해 static을 쓰기때문에
            //= 클래스이름.으로 사용하기 때문에, 왠만하면 외부의 클래스에서 호출하는 상황이 많음 
            //static은 왠만하면 public으로 사용된다.


        }
    }

}
