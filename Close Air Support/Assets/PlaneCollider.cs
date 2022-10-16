using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlaneCollider : MonoBehaviour
{
    [SerializeField] UnityEvent onCrashEvent;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ground")
        {
            onCrashEvent.Invoke();
        }

    }
  
}
