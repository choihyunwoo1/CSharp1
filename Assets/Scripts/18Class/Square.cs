using UnityEngine;

public class Square
{
    //이름을 반환하는 (정적, static)함수
    public static string Getname()
    {
        return "정사각형";
    }
}

/*Square 클래스의 Getname() (정적, static)메서드 호출
  
//호출 방법: 클래스 이름. 메서드 이름()
string name = Square.Getname();

Debug.Log(name);  

static일때만
아예 다른 파일에서 호출가능
*/

// Debug.Log(); = Debug라는 클래스 안에 Log라는 정적함수 호출 ()안에 매개변수