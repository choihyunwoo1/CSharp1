using Unity.VisualScripting;
using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    public int answer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        switch (answer)
        {
           
            case 1:
                Debug.Log("1번을 선택했습니다"); //실행문1
                break;
            case 2:
                Debug.Log("2번을 선택했습니다"); //실행문2
                break;
            case 3:
                Debug.Log("3번을 선택했습니다"); //실행문2
                break;
            case 4:
                Debug.Log("4번을 선택했습니다"); //실행문2
                break;
            default:
                Debug.Log("잘못 선택했습니다"); //실행문2
                break;

        }
        Debug.Log("프로그램 종료"); //실행문3

    }

}
/*
입력받은 수를 판별하여
1번을 선택했습니다 출력
2번을 선택했습니다 출력
3번을 선택했습니다 출력
4번을 선택했습니다 출력
다른 수라면 잘못 선택했습니다 라고 출력*/