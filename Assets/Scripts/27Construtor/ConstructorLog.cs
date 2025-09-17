using UnityEngine;

namespace constructor
{
    public class ConstructorLog
    {
        //기본 생성자
        public ConstructorLog()
        {
            Debug.Log("기본 생성자 실행");
        }

        //매개변수 string이 있는 생성자
        public ConstructorLog(string message)
        {
            Debug.Log($"오버로드 된 생성자 실행: {message}");
        }
    }
}