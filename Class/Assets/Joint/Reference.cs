using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �� Ÿ�� vs ���� Ÿ��
        int value = 10;
        int variable = 20;

        value = variable;

        // ���� Ÿ��
        Item hat = new Item();
        Item sword = new Item();

        hat.Information(1000, 10);
        sword.Information(5000, 10);

        // ���� Ÿ��
        hat = sword;

        Debug.Log("hat�� ���� : " + hat.price + " hat�� ũ�� : " + hat.size);
        Debug.Log("sword�� ���� : " + sword.price + " sword�� ũ�� : " + sword.size);
    }

    
    void Update()
    {
        
    }
}

public class Item
{
    public int price;
    public int size;

    public void Information(int price, int size)
    {
        this.price = price;
        this.size = size;  
    }
}