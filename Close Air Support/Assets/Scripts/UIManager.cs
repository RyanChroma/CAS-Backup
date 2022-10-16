using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlanePilot planePilot;
    public PlaneGun planeGun;
    public PlayerStat playerStat;
    public PlaneBomb planeBomb;

    public Text planeSpeed;
    public Text planeHeight;
    public float worldGround = -0.5f;

    public Text planeAmmo;
    public Text planeBombText;
    public Text planeHP;


    public void Update()
    {
        planeSpeed.text = planePilot.speed.ToString("0");
        planeHeight.text = (planePilot.transform.position.y - worldGround).ToString("0");

      
        planeHP.text = playerStat.playerCurrentHP.ToString("0");

        if (planeGun.reloading)
        {
            planeAmmo.text = "00:" + planeGun.reloadTime.ToString("0");
        }
        else
        {
            planeAmmo.text = planeGun.bulletsLeft.ToString("0");
        }

        if (planeBomb.isReloading)
        {
            planeBombText.text = "00:" + planeBomb.reloadTime.ToString("0");
        }
        else
        {
            planeBombText.text = planeBomb.bombAmmo.ToString("0");
        }
    }
}
