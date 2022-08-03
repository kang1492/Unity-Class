using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{   // 노출
    [SerializeField] bool state = false;
    [SerializeField] GameObject[] lightEffect;

    // 버튼3개 동시 컨트롤
    public void LightSetting(int number)
    {
        state = !state;
        lightEffect[number].SetActive(state);
    }
}
