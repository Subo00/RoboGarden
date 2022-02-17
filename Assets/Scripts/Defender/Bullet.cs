using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] int damage = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Attacker")
        {
            other.gameObject.GetComponent<Attacker>().HitRegister(damage);
            gameObject.SetActive(false);
        }    
    }
}
