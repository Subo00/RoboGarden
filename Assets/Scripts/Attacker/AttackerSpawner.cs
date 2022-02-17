using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    [SerializeField] private bool isActive = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        StartCoroutine("Spawn");
    }
   
    IEnumerator Spawn()
    {
         while(isActive)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            objectPooler.SpawnFromPool("Attacker0", transform.position, transform.rotation);
        }
    }
}
