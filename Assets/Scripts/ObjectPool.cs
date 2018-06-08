using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

    public static ObjectPool Instance;
    public List<GameObject> PooledObjects = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void PoolSpawnList( List<GameObject> _spawnList )
    {
        for(int i = 0; i < _spawnList.Count; i++)
        {
            GameObject _spawned = Instantiate(_spawnList[i]);
            PooledObjects.Add(_spawned);
            _spawned.SetActive(false);
        }
    }

    public void ClearObjectPool()
    {
        PooledObjects.Clear();
    }

}
