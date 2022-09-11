using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : EBaseSingleton<SpawnController>
{
    private bool IsFree;

    [SerializeField] Transform SpawnObject;
    [SerializeField] float SpawnTime;
    
    void Update()
    {
        if (IsFree)
        {
            Vector3 Pos = new Vector3(Random.Range(-0.7f, 0.7f), 2.4f, Random.Range(-3, -3));
            Instantiate(SpawnObject, Pos, Quaternion.identity);
            IsFree = false;
            StartCoroutine(SpawnDelay());
        }
    }

    private IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(SpawnTime);
        IsFree = true;
    }
}
