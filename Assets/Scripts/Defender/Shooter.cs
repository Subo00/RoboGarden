using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    ObjectPooler objectPooler;
    [SerializeField] private Vector3 gunPositionOffset;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    public void Fire()
    {
        objectPooler.SpawnFromPool("Bullet", transform.position + gunPositionOffset, transform.rotation);
        return;
    }
}
