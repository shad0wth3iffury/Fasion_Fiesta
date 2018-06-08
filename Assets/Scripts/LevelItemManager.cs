using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItemManager : MonoBehaviour {

    public List<GameObject> ObjectsToPool = new List<GameObject>();
    public List<Transform> GridPoint = new List<Transform>();

    private void Start()
    {
        ObjectPool.Instance.PoolSpawnList(ObjectsToPool);
        MoveToGrid();
    }

    void MoveToGrid()
    {
        for(int i = 0; i < GridPoint.Count; i++)
        {
            GameObject x = ObjectPool.Instance.PooledObjects[i];
            x.transform.position = GridPoint[i].position;
            x.SetActive(true);
        }
    }
}
