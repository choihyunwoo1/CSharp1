using UnityEngine;

public class SwitchDemo : MonoBehaviour
{
    public int x = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //switch (조건)
        switch (x)
        {
            case 1:
                Debug.Log("x는 1입니다."); //실행문1
                break;
            case 2:
                Debug.Log("x는 2입니다."); //실행문2
                break;
        }
        Debug.Log("프로그램 종료"); //실행문3

        //x=1: 실행문1 -> 실행문3
        //x=2: 실행문2 -> 실행문3
        //x=3: 실행문3 //default 조건식은 생략가능

    }

}

/*
 if(조건식)
{
    실행문1 - 참일때 실행
}
else
{
    실행문2 - 거짓일때 실행
}


switch(조건): Data 값 판별
{
    case 1번: 
        //실행문1
        Break;

    case 2번: 
        //실행문2
        Break;

    case 3번: 
        //실행문3
        Break;

    default:  //모든 경우가 아니면 
        //실행문4
        Break;
}
 */