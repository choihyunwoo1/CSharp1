using UnityEngine;

//[1]. 1차원 배열, 2차원 배열, 3차원 배열
public class ArrayOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]. 1차원 배열
        int[] intArray;

        //[2]. 1차원 배열 요소수 생성, 크기 결정, 메모리 영역 확보
        intArray = new int[3]; //{0번방},{1번방},{2번방} 생성됨

        //[3]. 배열 초기화
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;

        //[4]. 배열 사용
        /*for (int i = 0; i < 3; i++)
        {
            *//*Debug.Log($"{i}번째 방의 값은 {intArray[i]}");*//* // [i]는 index
            Debug.Log($"{i}번째 인덱스의 값은 {intArray[i]}");
        }*/

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm

        int i = 0;

        //배열 변수의 크기(길이)만큼 반복합니다 (intArray의 방 갯수{3번} 만큼 반복합니다)
        foreach (int num in intArray)
        {
            //반복 시행문
            Debug.Log($"{i}번째 방의 값은 {num}");
            i++;
        }
        
        //첫번째 반복때는 첫번째 방에 기입된 수를 집어넣고 시행,
        //그 다음번 시행때는 그 다음번 방에 저장된 수를... 하다가 마지막 방의 수까지 대입시행 후 종료

    }

}
/* 
    foreach({배열변수의 데이터타입} 변수이름 in 배열변수)
   {
       //반복 실행문
   }

 */