using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // �ʵ�
    // ���� ����
    // C# �Ľ�Į ǥ���(ù���ڰ� �빮��)�� ���� ǥ����� ����մϴ�.
    int health; // <- �ʱ�ȭ�� ���� �ʾƵ� 0�̶�� ������ ����˴ϴ�.
    int countIndex;

    void Start() // ���� ������Ʈ �Ӽ� �ʱ�ȭ
    {
        health = 100;
        Debug.Log(health);
    }

    
    void Update() // <- ����Ƽ���� �������ִ� �Լ�
    {
        // ����
    }
}
