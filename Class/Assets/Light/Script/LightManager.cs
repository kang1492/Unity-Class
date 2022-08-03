using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{   // ����
    [SerializeField] bool state = false;
    [SerializeField] GameObject[] lightEffect;

    // ��ư3�� ���� ��Ʈ��
    public void LightSetting(int number)
    {
        state = !state;
        lightEffect[number].SetActive(state);
    }
}
