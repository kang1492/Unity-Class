using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special : MonoBehaviour
{
    Rigidbody rigid;
    ParticleSystem effect;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        effect = GetComponentInChildren<ParticleSystem>();
    }

    private void OnMouseDown()
    {
        effect.Play();
    }

    private void OnMouseDrag()
    {
        rigid.isKinematic = true;

        // Mouse�� ��ġ�� �����մϴ�.
        Vector3 mousePosition = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.WorldToScreenPoint(gameObject.transform.position).z)
            ;
        // ���콺 ��ǥ�� screentoWorldPoint�� �����Ͽ� ������Ʈ�� ��ġ�� �����մϴ�.
        Vector3 objposition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objposition;
    }

    private void OnMouseUp()
    {
        rigid.isKinematic = false;
    }
}
