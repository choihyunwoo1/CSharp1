using UnityEngine;

public class FunctionReturn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2. 반환값이 있는 함수 호출
        //반환하는 데이터타입과 동일한 변수를 선언하여 반환되는 값을 저장
        string returnValue = GetString();
        Debug.Log(returnValue);
    }

    //1. 반환값(Return Value)이 있는 함수
    //(데이터 타입) 함수이름(매개변수)
    
    //문자열을 반환하는 함수
    string GetString()
    {
        //반환값이 없으면 에러가 뜸
        // return 키워드 뒤에는 함수 선언문에 있는 데이터 타입과 동일한 변수, 리터럴 값이 있어야한다.
        return "반환값(Return Value)"; 
    }
    
}
