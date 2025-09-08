using UnityEngine;

//데이터의 값(Literal)
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1.변수만들기 (선언)
        int num;  //정수형 변수
        double su; //실수형 변수
        bool flag; //부울형 변수
        string str; //문자열 변수
        char c; //문자형 변수

        //2.변수에 값 저장
        num = 1234;
        su = 3.14159;
        flag = true;   //true, false (참, 거짓) 둘중 하나
        str = "안녕하세요";  // 큰 따음표 안에서 한글자만 있더라도 문자열로 치환됨
        c = 'a';  //무조건 한글자만

        //3.변수 사용하기
        Debug.Log("num: " + num);
        Debug.Log("su: " + su);
        Debug.Log("flag: " + flag);
        Debug.Log("str: " + str);
        Debug.Log("c: " + c);

    }
        
}
