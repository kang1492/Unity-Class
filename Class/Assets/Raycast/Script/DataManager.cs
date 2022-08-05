using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public int money; // 저장하기 위한
    public int hat;
    public int stick;

    private void Awake()
    {
        // 최초 생성 이후에 갱신이 안되기 때문에 Awake( )함수에서 NULL체크를 합니다.
        if(instance == null)
        {
            // this를 static에 저장해야 꺼내서 사용할 수 있습니다.
            instance = this;
        }

        LoadData(); // 데이터 불러오기
    }

    
    //void Start()
    //{
    //    money += 100;
    //    Debug.Log(money);
    //}

    public void SaveData()
    {
        // 저장하기
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("hat", hat);
        PlayerPrefs.SetInt("stick", stick);
    }

    public void LoadData()
    {
        // 유니티 내부에 저장되어 있는 key("") 값을 불러옵니다.
        money = PlayerPrefs.GetInt("money");
        hat = PlayerPrefs.GetInt("hat");
        stick = PlayerPrefs.GetInt("stick");
    }

    public void InCreaseMoney()
    {
        money += 100;
        SaveData(); // 값을 저장.
    }
}
