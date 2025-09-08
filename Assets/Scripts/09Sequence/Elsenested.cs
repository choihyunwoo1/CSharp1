using UnityEngine;

// Else 중첩문
// char c에 문자 입력받아
// y를 입력받으면 YES 출력
// n을 입력받으면 NO 출력
// 그외의 문자가 들어오면 CANCEL 출력
public class Elsenested : MonoBehaviour
{
    public char c = 'a';

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (c == 'y' || c == 'Y') //y입력 받으면 YES출력
        {
            Debug.Log("YES");
        }
        else // y가 아니라면
        {
            if (c == 'n' || c == 'N') // n입력 받으면 NO출력
            {
                Debug.Log("NO");
            }
            else //아니면 CANCEL출력
            {
                Debug.Log("CANCEL");
            }
        }
        
    }

}
