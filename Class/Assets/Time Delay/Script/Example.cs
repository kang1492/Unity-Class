using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start() // <- Main 루틴
    {
        SubRoutine();
        Debug.Log("MainRoutine");
    }

    public void SubRoutine()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("SubRoutine[" + i + "]");
        }
    }

    public IEnumerator Delay()
    {
        Debug.Log("Corutine [1]");
        yield return new WaitForSeconds(1); // 1초간 기다린다
        Debug.Log("Corutine [2]");
        Debug.Log("Corutine [3]");
    }
}
