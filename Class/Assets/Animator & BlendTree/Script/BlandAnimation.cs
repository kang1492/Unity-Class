using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlandAnimation : MonoBehaviour
{
    private Animator animator; // ���� ����

    void Start()
    {
        // animator <- �ִϸ����� ������Ʈ
        animator = GetComponent<Animator>();// �������� ����
    }

    void Update()
    {

        // ���� ���� ����           //GetAxis ���� ���ϴ� �Է� ������ �־��־�� �մϴ�.
        // Left Key�� ������ -1
        // Right key�� ������ 1
        // x ������ -1 ~1 ������ ���� ��ȯ�մϴ�.
        // a d  �� ����Ű ������
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical"); // y��

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
    }
}
