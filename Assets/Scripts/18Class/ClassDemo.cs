using UnityEngine;

//클래스(class): 하나의 이름으로 서로다른 형식의 데이터들과 함수들을 묶어서 관리한다
//C# 에서 가장 기본이 되는 구문 
public class ClassDemo : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메서드(함수) 호출, 같은 클래스의 메서드
        Run();

        //ClassDemo 클래스의 메서드(함수) 호출
        ClassDemo.Run();  //클래스이름 . 메서드이름(); 으로 호출가능

    }

    //ClassDemo 클래스의 메서드(함수)
    static void Run()
    {
        Debug.Log("ClassDemo 클래스의 Run 메서드를 호출하였습니다.");
    }

}
