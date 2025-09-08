using UnityEngine;

//만약 입력받은 스코어가 60 이상이면 "합격"이라고 출력
//아니면 "불합격"이라고 출력
public class ElseNote : MonoBehaviour
{
    //정수형 변수 스코어 선언하고 초기화
    public int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (score >= 60) //60 이상이면 "합격"이라고 출력
        {
            //실행문1
            Debug.Log("합격");
        }
        else //아니면 실행문
        {
            //실행문2
            Debug.Log("불합격");
        }

        //실행문3
        Debug.Log("종료");

        //score = 59; -> 불합격 ㅡ> 종료
        //score = 60; -> 합격 ㅡ> 종료
    }
}
