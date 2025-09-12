using UnityEngine;
using System;

// Random 클래스 : 랜덤값과 관련된 변수, 메서드들이 있는 클래스
public class ClassRandom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   // Random 클래스의 객체 생성
        System.Random rand = new System.Random();  //객체(instance) 형성

        Debug.Log(rand.Next()); // Next : 임의의 정수 값 생성
        Debug.Log(rand.Next(5));  // 0~4 사이의 값중 무작위로 하나 생성
        Debug.Log(rand.Next(1, 10));  // 1~9 사이의 값중 무작위로 하나 생성 (최대값은 포함되지 않음)
    }

}
