using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    public int playerMaxHP = 100;
    public int playerCurrentHP = 100;

    public GameObject youDiedUI;

    public void Start()
    {
        playerMaxHP = 100;
    }

    public void OnTriggerEnter(Collider collision)
    {
        playerCurrentHP = playerCurrentHP - 1;
    }
}