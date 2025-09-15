using UnityEngine;
using System;

public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //str 문자(배)열(string, char[]) string 변수 선언하고 초기화
        string str = ""; //빈값으로 초기화
        str = String.Empty; //빈값으로 초기화
        str = " Abc Def Fed Cba "; //앞뒤에 공백 하나씩 주어서 값을 저장 - 문자열에는 띄어쓰기(공백) 또한 포함

        Debug.Log(str);
        Debug.Log(str.Length); //문자열 길이 구하기: 17
        Debug.Log(str[5]); //배열이기 때문에 인덱스 값을 넣어 활용가능: D
        Debug.Log(str.ToUpper()); //전부 대문자
        Debug.Log(str.ToLower()); //전부 소문자

        //공백 제거
        Debug.Log(str.Trim());  //앞쪽 부분에 있는 공백, 뒤쪽 부분의 공백들 제거
        Debug.Log(str.TrimStart());  //앞쪽에 있는 공백만 제거
        Debug.Log(str.TrimEnd());  //뒤쪽에 있는 공백만 제거

        //검색
        Debug.Log(str.IndexOf('e'));  // 'e'가 위치한 인덱스( 몇번 방인지를 ) 가져오기 답은 [6]
        Debug.Log(str.Substring(5, 3)); //5번 인덱스부터 3글자 가져오기
        Debug.Log(str.Substring(5));  //5번 인덱스부터 끝까지 가져오기
        Debug.Log(str.Remove(5, 3));  //5번 인덱스부터 3글자 삭제하기

        //비교
        Debug.Log(str[1] == str[15]); //false (1번방과 15번방의 문자가 같은가?) 
        Debug.Log("ABC".Equals("Abc")); //false (문자열은 대소문자 구분함)
        Debug.Log(String.Compare("BAC", "Bac")); //참과 거짓X = 0(같음), 앞의 문자열이 크다면 1(다름), 뒤의 문자열이 작으면-1(다름)

        //연결하기
        var hi1 = "안녕";
        var hi2 = "하세요";

        Debug.Log(hi1 + hi2); // +연산
        Debug.Log($"{hi1}{hi2}"); // 보간법
        Debug.Log(String.Format("{0}{1)", hi1, hi2)); // Format()

        //Format 사용
        Debug.Log(String.Format("{0:C}" , 1000));  // C 통화 단위를 표시하라 
        Debug.Log(String.Format("{0:#,###}", 100000));  // 3자리마다 ,(콤마)를 표시하라

        /*str = " Abc Def Fed Cba ";*/
        //분리하기, 전체 공백제거
        string[] strArray= str.Trim().Split(' '); //공백 단위로 분류하라 = 4개의 방(인덱스) 생성)
        string strAll = "";

        foreach (var item in strArray)
        { 
            strAll = strAll + item;
        }
        Debug.Log(strAll);  //AbcDefFedCba

    }

}
