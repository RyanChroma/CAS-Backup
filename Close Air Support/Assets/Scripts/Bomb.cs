using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public BoxCollider bombCollider;
    public GameObject bombExplosionEffect;
    [SerializeField] private float radius;
    [SerializeField] private float damage;

    public void OnTriggerEnter(Collider collision)
    {
    
        Collider[] c = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider g in c)
        {
            print(g);
            if(g.transform.TryGetComponent(out Health health))
            {
                health.ReduceHealth(damage);
            }
        }

        Instantiate(bombExplosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}