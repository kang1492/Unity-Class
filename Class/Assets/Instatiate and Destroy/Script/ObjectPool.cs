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
        // 외부에서 불러오기 때문에 자기 자신 넣기
        objPool = this;
        for(int i =0; i <10; i++)
        {
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false); // Queue 안에 들어 갈때 비활성화
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

        return tempPrefab; // 반환
    }
}
