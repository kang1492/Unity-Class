using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSystem : MonoBehaviour
{
    public float speed;

    void Start()
    {
        // �����ߴ� ������ �ҷ�����
        Load();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("speed", speed);
        //          ������ �Է�        ���
    }

    public void Load()
    {
                                    // Ű��
        speed = PlayerPrefs.GetFloat("speed");
    }
}
