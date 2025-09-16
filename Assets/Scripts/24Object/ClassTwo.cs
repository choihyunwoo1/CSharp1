using UnityEngine;

public class ClassTwo
{
    //정적(Static) 메서드
    public static void Hi()
    {
        Debug.Log("반갑습니다");
    }

    //인스턴스 메서드, Static이 없는 메서드
    public void Hello()
    {
        Debug.Log("또 만나요");
    }
}
