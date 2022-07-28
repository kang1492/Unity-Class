using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool objPool;

    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    void Start()
    {
        // �ܺο��� �ҷ����� ������ �ڱ� �ڽ� �ֱ�
        objPool = this;
        for(int i =0; i <10; i++)
        {
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false); // Queue �ȿ� ��� ���� ��Ȱ��ȭ
        }
    }
    
    public void InsertQueue(GameObject pobj)
    {
        queue.Enqueue(pobj);
        pobj.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject tempPrefab = queue.Dequeue();
        tempPrefab.SetActive(true);

        return tempPrefab; // ��ȯ
    }
}
