using UnityEngine;

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = int.MinValue;
        int max = int.MaxValue;

        Debug.Log("int 최소값: " + min);
        Debug.Log("int 최대값: " + max);

    }
}

    