using UnityEngine;

namespace Indexer
{
    public class Person
    {
        //필드
        private string name;

        //인덱서 구현 - name 필드의 값을 읽고 쓰는 인덱서
        public string this[int index]
        {
            get { return name; }  //인스턴스이름[인덱스] 호출하면 name 필드값 반환
            set { name = value; }  //인스턴스이름[인덱스] 호출해서 값을 저장하면 name 필드값에 저장
        }
        
    }

}
