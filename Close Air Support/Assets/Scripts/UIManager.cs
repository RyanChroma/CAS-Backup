using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlanePilot planePilot;
    public PlaneGun planeGun;
    public PlayerStat playerStat;

    public Text planeSpeed;
    public Text planeHeight;
    public float worldGround = -0.5f;

    public Text planeAmmo;
    public Text planeBomb;
    public Text planeHP;

    void Start()
    {
        
    }

    public void Update()
    {
        planeSpeed.text = planePilot.speed.ToString("0");
        planeHeight.text = (planePilot.transform.position.y - worldGround).ToString("0");
        planeAmmo.text = planeGun.bulletsLeft.ToString("0");
        planeBomb.text = planePilot.speed.ToString("0");
        planeHP.text = playerStat.playerCurrentHP.ToString("0");
    }
}
