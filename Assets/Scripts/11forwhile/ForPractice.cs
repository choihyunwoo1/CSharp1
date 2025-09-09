using UnityEngine;

public class ForPractice : MonoBehaviour
{
    public int n = 100;

        void Start()
    {
        // 1부터 n까지의 정수 중에서 3의 배수 또는 4의 배수 들의 합을 구하는 프로그램 구현

        int sum = 0;

        for (int i = 1; i <= n; i++)
        { 
            if (i%3 == 0 || i%4 == 0)
            {
                sum = sum + i;
            }
        }
        Debug.Log(sum);

    }

}
