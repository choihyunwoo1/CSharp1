using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Dictionary 제네릭 클래스 : Key-Value 값
public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Dictionary 제네릭 클래스 인스턴스 생성 : IDictionary 인터페이스로 받기
        IDictionary<string, string> datas = new Dictionary<string, string>(); //<KEY의 타입, Value의 타입>
        //[2] 데이터 입력
        datas.Add("도","경기도");
        datas.Add("시", "수원시");
        //[3] 데이터 삭제
        datas.Remove("도");
        //[4] 데이터 입력 - 인덱서를 이용하여 데이터 입력
        datas["구"] = "장안구";
        //[5] 키 값은 중복불가
        try
        {
            datas.Add("구", "강동구");
        }
        catch (System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
        //[6] 사용
        foreach (KeyValuePair<string, string> item in datas)
        {
            Debug.Log($"{item.Key} - {item.Value}");
        }
        //[7] 인덱서를 이용해서 데이터 사용
        Debug.Log(datas["구"]);
        Debug.Log(datas["시"]);
    }
}
