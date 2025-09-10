using UnityEngine;

public class BreakWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 0;

        //number가 5이상이면 while문 종료

        while (true)  //무한 루프
        {
            
            
            if (number >= 5)
            {
                break;
            }
           
            Debug.Log("안녕하세요"); //반복 실행문
            number++;
        }



    }

}
