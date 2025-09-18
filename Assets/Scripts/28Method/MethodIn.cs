using UnityEngine;
namespace Method
{
    public class MethodIn : MonoBehaviour
    {
        public struct Point
        {
            public int x;
            public int y;
        }
        //값 전달 방식 (int num), 구조체
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
/*            int num = 10;
            Debug.Log($"[1]: {num}");

            PrintNumber(num);

            Debug.Log($"[3]: {num}");*/



            //구조체 변수 선언하고 초기화
            Point point = new Point();
            point.x = 10;

            Debug.Log($"[1]: {point.x}");

            PrintNumber(point);

            Debug.Log($"[3]: {point.x}");
        }

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]: {num}");
        }

        private void PrintNumber(Point p)
        {
            p.x = 20;
            Debug.Log($"[2]: {p.x}");
        }
    }

}