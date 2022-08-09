using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSystem : MonoBehaviour
{
    public float speed;

    void Start()
    {
        // 저장했던 데이터 불러오기
        Load();
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("speed", speed);
        //          데이터 입력        밸류
    }

    public void Load()
    {
                                    // 키값
        speed = PlayerPrefs.GetFloat("speed");
    }
}
