using UnityEngine;

namespace Method
{
    //참조 전달 방법(Refernce), 클래스의 인스턴스
    public class MethodRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            //몬스터 생성
            Monster monster1 = new Monster(100,10);
            Monster.monsterCount++;  // . 을 이용하여 단 하나만 존재하는 정적함수 위치를 참조하여 수치변경

            Monster monster2 = new Monster(200, 20);
            Monster.monsterCount++;

            //전투
            // MonsterBattle(monster1, monster2);
            // MonsterBattle(monster2, monster1);
            monster2.TakeDamage(monster1.atk);
            monster1.TakeDamage(monster2.atk);

            //UI
            Debug.Log($"monster1 hp:{monster1.hp},atk: {monster1.atk}");
            Debug.Log($"monster1 hp:{monster2.hp},atk: {monster2.atk}");

            Debug.Log($"Monster Count: {Monster.monsterCount}");


        }

        //전투하는 함수, 공방식 : hp -= atk;
        //매개변수로 공격하는 몬스터와 방어하는 몬스터를 입력받아 공방식 적용
        void MonsterBattle(Monster atkMonster, Monster DefMonster)
        {
            //공방식
            DefMonster.hp -= atkMonster.atk;
        }







    }

}