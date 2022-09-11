using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCurtainSystem : EBaseSingleton<BallCurtainSystem>
{
    private Queue<GameObject> PoolObject;

    [SerializeField] GameObject BallPrefab;
    [SerializeField] int PoolSize;
    private void Awake()
    {
        PoolObject = new Queue<GameObject>();
        for (int i = 0; i < PoolSize; i++)
        {
            GameObject go = Instantiate(BallPrefab);
            GetPutBall(go);
        }
    }    

    public GameObject GetButBall()
    {
        var go = PoolObject.Dequeue();
        return go;
    }

    public void GetPutBall(GameObject gameObject)
    {
        PoolObject.Enqueue(gameObject);
        gameObject.SetActive(false);
    }
}
