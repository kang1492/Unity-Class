using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneriecStoneDelete : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // OnBecameInvisible() : 카메라가 랜더링하는 시야 범위로 벗어났을 때 호출되는 함수

    private void OnBecameInvisible()
    {
        if(gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject); // 게임오브젝트 상속중
        }

        else if(gameObject.name == "Stone_5(Clone)")
        {
            rigid.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(0, 5, 0);
            ObjectPool.objPool.InsertQueue(gameObject);
        }
    }
}
