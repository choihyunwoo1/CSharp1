using UnityEngine;

// Var : 암시적으로 형식화된 로컬 변수
public class VarDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int i = 1234;           //정수
        string s = "안녕하세요"; //문자열
        char c = 'a';           //문자
        double d = 3.14;        //실수형

        Debug.Log(i.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
        Debug.Log(d.GetType());*/


        // 1. Var는 뒤에오는 선언을 보고 그에 맞추어서 타입을 지정
        //var는 무조건적으로 선 초기화(변수 선언) 후 사용 , 즉 자진 초기화(선언)가 안되므로 Var는 함수 안에서만 사용하는 변수

        var name = "홍길동";    // "홍길동" 값을 보고 name이란 변수의 타입을 string(문자열)이라고 결정
        Debug.Log(name);
        Debug.Log(name.GetType()); 


        var Version = 8.0;      // 8.0 값을 보고 version란 변수의 타입을 double(실수형)형으로 결정
        Debug.Log(Version);
        Debug.Log(Version.GetType());


        var number = 1;         // 1 리터럴 값을 보고 number란 변수의 타입을 int(정수형)형으로 결정
        Debug.Log(number);
        Debug.Log(number.GetType());




    }

}
