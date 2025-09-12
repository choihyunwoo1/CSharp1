using JetBrains.Annotations;
using UnityEngine;

//학생들의 성적을 관리하는 구조체
struct Student
{
    public int number;  //번호
    public string name; //이름
    public score score; //구조체 안의 구조체(중첩 구조체)
}

//과목별 점수를 관리하는 구조체
struct score
{
    public int kor;
    public int eng;
}

public class StructurePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1. 구조체 사용 - 배열 변수 선언, 요소수 생성
        Student[] s = new Student[3];
        
        //2. 구조체 변수들 초기화
        s[0].number = 1;
        s[0].name = "홍길동";
        s[0].score.kor = 100;
        s[0].score.eng = 90;

        s[1].number = 2;
        s[1].name = "백두산";
        s[1].score.kor = 90;
        s[1].score.eng = 85;

        s[2].number = 3;
        s[2].name = "임꺽정";
        s[2].score.kor = 90;
        s[2].score.eng = 80;

        //사용 - 학생 성적표 출력
        for (int i = 0; i < s.Length; i++)
        {
            Debug.Log($"{s[i].number} - {s[i].name}: 국어{s[i].score.kor}, 영어{s[i].score.eng}");
        }

        //Square 클래스의 Getname() 메서드 호출
        //호출 방법: 클래스 이름. 메서드 이름()
        string name = Square.Getname();
        Debug.Log (name);

    }

}
