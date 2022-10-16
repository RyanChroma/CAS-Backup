using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Rigidbody bullet;
    [SerializeField] private GameObject model;
    [SerializeField] private GameObject looker;
    [SerializeField] private float shotCooldown;
    private float _shotCoolDown;
    [SerializeField] private float damage;
    [SerializeField] private float shotForce;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float distanceLimit;
    private GameObject player => GameObject.FindGameObjectWithTag("Player");

    private void Start()
    {
        _shotCoolDown = shotCooldown;
    }

    private void Update()
    {
        if(distanceLimit >= Vector2.Distance(transform.position, player.transform.position))
        {
            ShootBullet();
        }


        looker.transform.LookAt(player.transform.position);
        model.transform.LookAt(new Vector3(player.transform.position.x,transform.position.y,player.transform.position.z));
    }

    public void ShootBullet()
    {
        shotCooldown -= Time.deltaTime;

        if(shotCooldown <= 0)
        {
          Rigidbody rb = Instantiate(bullet,transform.position,looker.transform.rotation);
            rb.AddForce(looker.transform.forward * shotForce,ForceMode.Impulse);
            shotCooldown = _shotCoolDown;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, distanceLimit);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position,( player.transform.position - transform.position).normalized * distanceLimit);
    }

}
