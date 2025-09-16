using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// As 연산자 : ~형식으로 변환이 가능하면 변환, 변환이 불가능하면 null (예외(Exception) 안 터짐)

/*
is → “이게 맞는 타입이야?” (맞으면 true/false)
as → “맞으면 변환해줘, 안 맞으면 null 줘”
                    V
is : “박스 안에 들어 있는 게 사과야?” (O/X로만 대답)
as : “박스 안에 들어 있는 걸 사과로 꺼내줘. 근데 사과 아니면 그냥 빈손(null) 줘.”   */

public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "반갑습니다";
        string r1 = s as string;
        Debug.Log(r1);  //변환이 가능하기에 변환됨

        object i = 1234;
        string r2 = i as string;
       /* Debug.Log(r2); */ //변환이 불가능하기에 null
        if (r2 == null)
        {
            Debug.Log("Null입니다.");
        }

        object j = 5678;
        if (j is string)
        {
            string r3 = j as string;
            Debug.Log(r3);
        }
        else
        {
            Debug.Log("변환이 안됩니다.");
        }


    }
}
