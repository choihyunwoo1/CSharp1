using UnityEngine;

//매개변수(Parameter)가 있는 함수 만들고 호출하기
public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2.매개변수가 있는 함수 호출하기
        ShowMessage("매개 변수");  //호출 후 값을 대입하며 초기화!!! = 인수
        ShowMessage("안녕하세요");
    }

    //매개변수가(Parameter)가 있는 함수 선언하기
    //기능: 매개변수를 통해 들어온 문자열을 출력하기
    void ShowMessage(string Message) //매개변수: 데이터 타입(string)과 변수 이름(Message)
    {          
        Debug.Log(Message); //출력 
    }
    // 저장(초기화)이 안되어있음 
    //함수 호출할때 값을 넣고 초기화!!!
}
