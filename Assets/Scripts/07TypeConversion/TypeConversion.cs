using UnityEngine;

// 형식 변환 (TypeConversion)
public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // d를 double형 변수로 선언하고 12.34를 (저장/초기화)
        double d = 12.34;  // 64Bit
        // i를 인트형 변수로 선언하고 1234롤 (저장/초기화)
        int i = 1234;    // 32Bit


        // 1. 묵시적 형식 변환
        d = i; 
       /*실수형 그릇이 정수형 그릇보다 크기에 형식도 변수형식도 달라도 저장이 가능 
         위와같은 상황을 묵시적,암묵적 형식 변환  
        본래 맞는 문법은 d = (double)i;   {넘치지만 않는다면 암묵적 형식변환 가능)
       */
        Debug.Log($"암시적 형식변환: {d}");

        d = 12.33;
        i = 1234;

        // 2. 명시적 형식 변환 (숫자간에만 가능 문자열,형 불가능)
        i =(int) d; // d가 그릇이 더 크기에 그릇이 작은 i에 안들어감 그러므로 강제로 int를 붙여 형식을 변환시킴
        Debug.Log($"명시적 형식변환: {i}");   // 12라고만 출력되는데, 정수형 그릇이라 소숫점이 생략됨

        d = 12.34;

        // 3. 수 이외 형식간 변환
        string s = ""; //글자가 없는 상황을 {EMPTY} '빈값으로 초기화 한다'라고 칭한다
        s = d.ToString(); 
        Debug.Log($"형식변환: {s}");   // 12.34라고 출력 되지만 이는 숫자가 아닌 문자열로 치환된다.






    }

  
}
