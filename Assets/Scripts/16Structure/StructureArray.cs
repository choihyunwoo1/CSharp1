using System.Globalization;
using UnityEngine;

//1. 구조체 정의 및 선언
//고객 데이터 관리하는 구조체
struct BusinessCard
{
    public string name;
    public int age;
}

public class StructureArray : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //2.구조체 사용 - 구조체 변수 선언
        BusinessCard B;

        //3. 구조체에 속해 있는 데이터들의 초기화
        B.name = "홍길동";
        B.age = 20;

        //4. 구조체 출력
        Debug.Log($"제 이름은 {B.name}, 나이는 {B.age}입나다.");

        PrintBusinessCard(B.name, B.age);
        PrintBusinessCard(B);

        //[1].구조체 사용 - 구조체 배열 변수 선언
        BusinessCard[] bizCards = new BusinessCard[2];

        //[2].배열 구조체 변수들 초기화
        bizCards[0].name = "백두산";
        bizCards[0].age = 20;

        bizCards[1].name = "임꺽정";
        bizCards[1].age = 30;

        //[3].배열 구조체 변수들 사용 
        for (int i = 0; i < bizCards.Length; i++)
        {
            //PrintBusinessCard(bizCards[i].name, bizCards[i].age);
            PrintBusinessCard(bizCards[i]);
        }
    }

    //고객 정보를 출력하는 함수
    void PrintBusinessCard(string nname, int aage)
    {
        Debug.Log($"{nname} 고객님의 나이는 {aage}살 입니다.");
    }

    //고객 정보를 출력하는 함수
    void PrintBusinessCard(BusinessCard card)
    {
        Debug.Log($"이름: {card.name} 나이: {card.age}");
    }

}
