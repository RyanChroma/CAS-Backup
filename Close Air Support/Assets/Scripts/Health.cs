using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private UnityEvent onDeath;
    public void ReduceHealth(float _health)
    {
        health -= _health;

        if(health <= 0)
        {
            onDeath.Invoke();
      
        }
    }

    public void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
