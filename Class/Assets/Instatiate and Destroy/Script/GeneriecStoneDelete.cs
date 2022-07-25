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

    // OnBecameInvisible() : ī�޶� �������ϴ� �þ� ������ ����� �� ȣ��Ǵ� �Լ�

    private void OnBecameInvisible()
    {
        if(gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject); // ���ӿ�����Ʈ �����
        }

        else if(gameObject.name == "Stone_5(Clone)")
        {
            rigid.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(0, 5, 0);
            ObjectPool.objPool.InsertQueue(gameObject);
        }
    }
}
