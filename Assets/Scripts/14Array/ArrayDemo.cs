using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 배열 선언 - 정수형 데이터를 담는 배열 선언
        int[] numbers;

        //[2] 배열의 요소수 생성(배열의 크기) - 그릇 갯수 지정,
        numbers = new int[n]; //0~9번방까지 존재함 , 0~(n-1)번방까지 존재함.

        //[3] 배열의 초기화
        numbers[0] = 3480; //0번방에 3480이라는 값을 넣겠다. {[]번방에 []값을 넣겠다~}
        numbers[1] = 2160;

        //[4] 배열의 사용
        Debug.Log($"{numbers[0]},{numbers[1]},{numbers[2]}");
        
    }
}

/*
    배열(Array): 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇
    
     //배열선언  //변수 선언    //점수
    데이터 타입[] 변수명(이름) = {점수};
*/