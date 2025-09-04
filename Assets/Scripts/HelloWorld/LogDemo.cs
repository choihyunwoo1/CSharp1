using UnityEngine;

public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(("결과는: " + 5));   // 5

        Debug.Log("결과는: " + (5 + 10));   // 15

        Debug.Log("결과는: " + 5 + 10);   // 510
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
