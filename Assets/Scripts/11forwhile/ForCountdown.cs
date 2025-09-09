using UnityEngine;

public class ForCountdown : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 5까지 카운트다운 하는 프로그램 구현
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log($"증가 카운트다운: {i}");
        }

        Debug.Log("===============================");

        // 5부터 까지 1카운트다운 하는 프로그램 구현
        for (int i = 5; i >= 1; i--)
        {
            Debug.Log($"감소 카운트다운: {i}");
        }



    }

}
