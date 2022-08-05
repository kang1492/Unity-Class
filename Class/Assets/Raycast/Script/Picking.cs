using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    public LayerMask layer; // ��ü �Ǻ�
    public RaycastHit hit;
    
    void Update()
    {   
        // GetMouseButton(0) : ���콺 ���� ��ư�� Ŭ������ ��
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // ������ �߻��� ���� ������ �浹�� ���� ������Ʈ�� �ִٸ� hit ������ �����͸� �����մϴ�.
            if(Physics.Raycast(ray, out hit)) // layer�� �ش� layer�� �����Ͽ� �浹�մϴ�.
            { // layer ���� ��.
                //Debug.Log("�浹"); // �浹 �׽�Ʈ
                hit.collider.gameObject.GetComponent<Renderer>().material = Resources.Load<Material>("Ice");
            }
        }
    }
}
