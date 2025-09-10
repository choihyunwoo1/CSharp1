using UnityEngine;

public class ContinueDemo : MonoBehaviour
{
    public int n = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            sum = sum + i; // sum += i; 로 대체 가능
        }
        Debug.Log(sum);
    }

}
/*[Q] 1부터 100까지의 정수의 합을 구하는데, 3의 배수를 제외하고 합을 구하시오*/