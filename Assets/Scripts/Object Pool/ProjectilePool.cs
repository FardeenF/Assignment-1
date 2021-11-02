using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePool : MonoBehaviour
{
    public static ProjectilePool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectPoolPrefab;
    public int amountToPool;
    void Awake()
    {
        SharedInstance = this;
    }
    void Start() 
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectPoolPrefab);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }



    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}