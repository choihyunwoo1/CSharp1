using UnityEngine;

namespace Property
{
    public class Person
    {
        //필드
        private string name;   //이름

        //속성(Property)를 이용해서 name애 접근 사용
        //public [반환타입] 속성이름 { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //private한 필드를 public한 메서드를 이용해서 쓰고 읽는다
        public void SetName(string _name)
        { 
            name = _name;
        }

        public string GetName()
        { 
            return name;
        }

    }

}
