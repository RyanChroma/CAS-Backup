using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public BoxCollider bombCollider;
    public GameObject bombExplosionEffect;

    public void OnTriggerEnter(Collider collision)
    {
        Instantiate(bombExplosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}