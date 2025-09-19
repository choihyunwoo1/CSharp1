using UnityEngine;

namespace Delegate
{
    public class DelegateAll : MonoBehaviour
    {
        delegate void GoHome();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1]직접운전
         /*   CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoForward();
            CarDriver.GoLeft();

            //[2]대리자 변수에 메서드 호출
            go += new GoHome(CarDriver.GoForward);

            //[3] 대리자 실행
            go.Invoke();
            */




        }

    }

}
