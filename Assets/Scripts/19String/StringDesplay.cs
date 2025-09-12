using UnityEngine;

//문자열 묶는 방법:  +, 보간법($), Format()
public class StringDesplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string displayName = "";
        string firstName = "길동";
        string lastName = "홍";
    
        //1. output : "이름: 홍 길동"
        //문자열 +(더하기) 연산자
        displayName = "이름: " + lastName + "" + firstName ;
        Debug.Log(displayName);

        //2. 문자열 보간법 사용
        displayName = $"이름: {lastName} {firstName}";
        Debug.Log(displayName);

        //3. string.Format() 메서드 사용
        displayName = string.Format("이름: {0} {1}", lastName, firstName);
        Debug.Log(displayName); 
    }

}
