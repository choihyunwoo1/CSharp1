using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    public int x = 5;
    public int y = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = 0;
        try //예외가 발생할 가능성이 있는 구문이 들어오는 코드블록
        {
            result = x / y;  //0으로 나누면 예외발생, 여기서 try절 중단 후 catch절 실행
            //[1]번 구문
            Debug.Log($"{x}/{y}={result}");
        }
        catch //try절에서 예외가 발생하면 catch절을 실행
        {
            //[2]번 구문
            Debug.Log("예외가 발생 했습니다.");
        }
        finally //try절에서 예외가 발생하던 안하던 상관없이 finally절은 무조건 실행
        { 
            //[3]번 구문
            Debug.Log("Finally절을 실행 합니다");    
        }

        /*실행 순서
        [1] -> [3]  //0으로 나누어질 경우
            or
        [2] -> [3]  //0으로 나누어지지 않을 경우
        */

    }
}
