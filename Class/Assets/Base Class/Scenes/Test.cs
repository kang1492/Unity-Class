using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   
    void Start()
    {
        Orc orc = new Orc();
        // 객체 생성
        Dragon dragon = new Dragon();
    }
    
}

public class Monster
{
    public void Attack()
    {
        Debug.Log("공격한다.");
    }

    protected void Information(int health, int level)
    {
        Debug.Log("체력 : " + health + " 레벨  : " + level);
    }
}

public class Orc : Monster
{
    public Orc()
    {
        base.Attack();
        base.Information(100, 5);
    }
}

public class Dragon : Monster
{
    public Dragon()
    {
        base.Attack();
        base.Information(2000, 100);
    }
}