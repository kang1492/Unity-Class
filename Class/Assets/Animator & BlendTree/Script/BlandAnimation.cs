using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlandAnimation : MonoBehaviour
{
    private Animator animator; // 변수 설정

    void Start()
    {
        // animator <- 애니메이터 컴포넌트
        animator = GetComponent<Animator>();// 가져오게 설정
    }

    void Update()
    {

        // 수평에 대한 정보           //GetAxis 에는 원하는 입력 정보를 넣어주어야 합니다.
        // Left Key를 누르면 -1
        // Right key를 누르면 1
        // x 축으로 -1 ~1 사이의 값을 반환합니다.
        // a d  와 방향키 누르면
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); // y축

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
