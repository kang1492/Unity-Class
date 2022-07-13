using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    int health = 0;

    private void Awake()
    {
        Debug.Log("Tiger");
    }

    void Start()
    {
        Debug.Log("Tiger Start");
    }

    private void OnEnable()
    {
        Debug.Log("Tiger OnEnable");
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }

    private void Update()
    {
        health++;
        Debug.Log(health);

        if(health >= 100)
        {
            health = 0;
        }
    }

    //헬스가 100을 넘거 가면 다시 0으로 만들어 주세요

    
}
