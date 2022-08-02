using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 값 타입 vs 참조 타입
        int value = 10;
        int variable = 20;

        value = variable;

        // 참조 타입
        Item hat = new Item();
        Item sword = new Item();

        hat.Information(1000, 10);
        sword.Information(5000, 10);

        // 참조 타입
        hat = sword;

        Debug.Log("hat에 가격 : " + hat.price + " hat에 크기 : " + hat.size);
        Debug.Log("sword에 가격 : " + sword.price + " sword에 크기 : " + sword.size);
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