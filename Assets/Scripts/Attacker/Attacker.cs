using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] int hitPoints = 10;
    private SpriteRenderer spriteRenderer;
    private Material originalMaterial;
    [SerializeField] private Material flashMaterial;
    [SerializeField] private float flashDuration;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalMaterial = spriteRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);

    }

    public void HitRegister(int damage)
    {
        hitPoints -= damage;
        StartCoroutine(FlashRoutine());
        if(hitPoints <= 0)
        {
            Death();
        }
    }

    void Flash()
    {
        
    }

    IEnumerator FlashRoutine()
    {
        spriteRenderer.material = flashMaterial;
        yield return new WaitForSeconds(flashDuration);
        spriteRenderer.material = originalMaterial;
        flashFlag = null;
    }
    private void Death()
    {
        //add animation for explosion
        //add sound for that as well
        gameObject.SetActive(false);
    }
}
