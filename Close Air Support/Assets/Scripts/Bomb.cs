using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float bombDestroyTimer = 0.0f;
    public BoxCollider bombCollider;
    public Transform bombExplosionEffect;

    public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Bomb hit");
        Destroy(gameObject);
    }
}
