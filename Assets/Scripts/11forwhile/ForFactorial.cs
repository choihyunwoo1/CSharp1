using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    public int n = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 4!을 값을 구하라
        int factorial = 1;

        for (int i = 1; i <=n; i++)
        {
            factorial = factorial * i;
        }
        Debug.Log($"{n}!값은 {factorial}");
    }
}

/*
 Factorial (!)
 1! = 1
 2! = 1x2
 3! = 1x2x3
 4! = 1x2x3x4
 n! = 1x ~(n-1)x(n)
 */