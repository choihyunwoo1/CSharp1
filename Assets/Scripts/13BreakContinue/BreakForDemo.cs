using UnityEngine;

// Break; : 반복문(for, while) { } 을 빠져나오는 명령문
//        = 반복문(for, while)을 강제 종료시칸다
public class BreakForDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //5번 반복하는 for문 작성 - i가 2일때 for문을 종료
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("안녕하세요"); //반복 실행문
            //i가 2라면 멈춰라
            if (i == 2)
            {
                break;
            }
        }     
        //출력문의 위치에 따라 Break위에 있으면 3번, 아래있으면 2번 실행됨
        //무조건 출력순서는 위에서 아래로.






    }

}
