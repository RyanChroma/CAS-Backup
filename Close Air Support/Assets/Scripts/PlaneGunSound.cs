using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneGunSound : MonoBehaviour
{
    public AudioSource playerGunSound;
    public PlaneGun planeGun;
    
    void Start()
    {
        playerGunSound.enabled = false;
    }

    void Update()
    {
        if (planeGun.reloading)
        {
            playerGunSound.enabled = false;
            return;
        }

        if(Input.GetKey(KeyCode.Mouse0))
		{
            playerGunSound.enabled = true;
		}
		else
		{
            playerGunSound.enabled = false;
		}
    }
}
