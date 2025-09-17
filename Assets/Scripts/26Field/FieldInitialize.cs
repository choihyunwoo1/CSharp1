using UnityEngine;
using Field;

namespace Field  //네임스페이스가 타 파일과 동일하면 using을 사용하지 않아도 같이 묶임
{
    public class FieldInitialize : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Say 클래스의 인스턴스 생성
            Say say = new Say();
            say.Hi();
            
        }

    }
}

