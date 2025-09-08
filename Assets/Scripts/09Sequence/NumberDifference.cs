using UnityEngine;

public class NumberDifference : MonoBehaviour
{
    public int first = 0;
    public int second = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int diff = 0;

        if (first >= second)
        { 
            diff = first - second;
           // Debug.Log($"{first} - {second}: {diff} ");
        }
        else
        {
            diff = second - first;
           // Debug.Log($"{second} - {first}: {diff} ");
        }
        Debug.Log($"{first}와 {second}의 차이는 {diff}이다");

        Debug.Log("종료");
    }

}
/* 두개의 정수를 입력받아 두 정수의 차이를 양의 정수로 구하시오
 first, second

output : 
{first} 값과 {second} 값의 차이는 {diff}이다
 */