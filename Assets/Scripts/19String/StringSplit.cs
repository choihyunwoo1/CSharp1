using UnityEngine;

// Split(): 문자열 분리하기
public class StringSplit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언하고 초기화
        string str = "Red,Freen,Blue";

        // Split() 문자열에서 특정 구분자( , or $ or | )를 사용하여 문자열을 배열로 만들수 있다
        //받는 그릇을 배열로 설정
        string[] colors = str.Split(','); //구분자 매개변수에 설정

        for (int i = 0; i < colors.Length; i++)
        { 
             Debug.Log(colors[i]);
        }
    }

}
