using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 필드
    // 변수 선언
    // C# 파스칼 표기법(첫글자가 대문자)과 가멜 표기법을 사용합니다.
    int health; // <- 초기화를 하지 않아도 0이라는 값으로 저장됩니다.
    int countIndex;

    void Start() // 게임 오브젝트 속성 초기화
    {
        health = 100;
        Debug.Log(health);
    }

    
    void Update() // <- 유니티에서 제공해주는 함수
    {
        // 로직
    }
}
