using UnityEditor.Rendering;
using UnityEngine;

//할당(대입) 연산자 (=) : 변수에 값을 저장
public class AssignmentDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /* string name = "홍길동";
        int age = 19;
        Debug.Log($"이름은 {name}, 나이는 {age} ");*/

        //변수 선언 및 초기화
        int i = 100;
        int j = 200;

        //빈 박스 생성
        int temp;

        //변수 출력
        Debug.Log($"처음값 i: {i}, j: {j}");

        temp = i;     // i의 값을 temp에 저장(참조) / i의 값이 없어지는 것이 아님
        i = j;       // i에 j를 저장
        j = temp;   // j에 temp에 담긴 i값을 저장
                   //따라서 i=200 , j=100

        //변수 출력
        Debug.Log($"나중값 i: {i}, j: {j}");



    }


}

/* 
[Q]
+,- 등 다른 연산없이 변수 i와 j의 값을 서로 바꾸어서 저장하세요
hint) temp 변수를 만들어서 이용하세요
 [output] 
처음값 i = 100 , j = 200
나중값 i =200 , j = 100

 */