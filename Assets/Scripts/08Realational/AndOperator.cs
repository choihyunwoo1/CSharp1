using UnityEngine;

//
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1.AndOperator(And연산자)
        Debug.Log( true && true ); // 앞뒤 모두 참일경우 참(true)
        Debug.Log( true &&  false ); // 둘중에 하나라도 거짓일 경우 거짓(false)
        Debug.Log( false && true );  // (false)  
        Debug.Log( false && false ); // (false)

        //2.OrOperator(Or연산자)
        Debug.Log(true || true); // 앞뒤 모두 참일경우 참(true)
        Debug.Log(true || false); // 둘중에 하나라도 참일 경우 참(true)
        Debug.Log(false || true);  // (true)  
        Debug.Log(false || false); //둘다 모두 거짓일 경우 거짓(false)

        //3.NotOperator(부정 연산자)
        Debug.Log(!true);    //참을 부정 (false)
        Debug.Log(!false);   //거짓을 부정 (true)
        

    }

}
/* 1. AndOperator (And연산자) : &&
   && : 모두 참일때만 참
   2. OrOperator (Or연산자) :||  (백스페이스 왼쪽의 원 표시 shift)
   || : 하나만 참이어도 참
   3. NotOperator(부정 연산자)
   ! : 참이면 거짓, 거짓이면 참으로 뒤집기
 */