using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor;

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasPackage && collision.CompareTag("Package"))
        {
            Debug.Log("You got package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }

        if (hasPackage && collision.CompareTag("Customer"))
        {
            Debug.Log("You delivered package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
