using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public int money; // �����ϱ� ����
    public int hat;
    public int stick;

    private void Awake()
    {
        // ���� ���� ���Ŀ� ������ �ȵǱ� ������ Awake( )�Լ����� NULLüũ�� �մϴ�.
        if(instance == null)
        {
            // this�� static�� �����ؾ� ������ ����� �� �ֽ��ϴ�.
            instance = this;
        }

        LoadData(); // ������ �ҷ�����
    }

    
    //void Start()
    //{
    //    money += 100;
    //    Debug.Log(money);
    //}

    public void SaveData()
    {
        // �����ϱ�
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("hat", hat);
        PlayerPrefs.SetInt("stick", stick);
    }

    public void LoadData()
    {
        // ����Ƽ ���ο� ����Ǿ� �ִ� key("") ���� �ҷ��ɴϴ�.
        money = PlayerPrefs.GetInt("money");
        hat = PlayerPrefs.GetInt("hat");
        stick = PlayerPrefs.GetInt("stick");
    }

    public void InCreaseMoney()
    {
        money += 100;
        SaveData(); // ���� ����.
    }
}
