using UnityEngine;

//전역변수, 필드, 멤버변수
//지역변수 
public class Functionscope : MonoBehaviour
{
    string message = "전역 함수"; //필드, 멤버변수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage();

        Debug.Log(message);
        PrintMessage();
    }
    //메세지를 출력하는 함수
    void ShowMessage()
    {
        string message = "지역 변수";
        Debug.Log(message);
    }

    void PrintMessage()
    {
        Debug.Log(message);
    }

}

/* 
  
 */