using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab;

    public void GenericCreate()
    {      
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);      
    }

    public void PoolCreate()
    {
        ObjectPool.objPool.GetQueue(); // 큐에서 꺼내서 오브젝트 쓰는것
    }
}
