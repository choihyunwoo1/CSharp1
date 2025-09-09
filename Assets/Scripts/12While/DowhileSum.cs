using UnityEngine;

//Dowhile문을 이용해서 1부터 100까지의 정수중 홀수들의 합을 구하는 프로그램 구현
public class DowhileSum : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        int i = 1; //초기식

        do
        {
            if (i % 2 == 1)
            {
                sum = sum + i; //반복실행문
            }

            i++;  //증감식            
        } while (i <= n); //조건식

        Debug.Log(sum);
    }

}
