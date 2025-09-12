using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

//1. enum 정의, 선언
//우선 순위를 정의하는 열거형 생성
enum prority
{ 
    High,
    Normal,
    Low
}
public class EnumerationDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2. 사용 - 변수 선언
        prority high = prority.High;
        prority normal = prority.Normal;
        prority low = prority.Low;

        Debug.Log($"{high},{normal},{low}");



    }
}
/*
  열거형(Enumeration, Enum)
 :하나의 이름으로 서로 관련있는 정수 값을 갖는 상수들의 집합
 :사용자 정의 데이터 형식
  
enum (enum 이름)
{
    상수명,
    상수명,
    ...
}
 */
