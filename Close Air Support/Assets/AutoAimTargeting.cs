using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAimTargeting : MonoBehaviour
{
    public Camera cam => Camera.main;
    public AutoAimer autoAimer => GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<AutoAimer>();
    public Renderer renderer => GetComponent<Renderer>();

    private bool IsVisible(Camera c, GameObject target)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(c);
        var point = target.transform.position;

        foreach (var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
            {
                return false;
            }
        }
        return true;
    }

    private void Update()
    {
        if (renderer.isVisible)
        {
            autoAimer.AddToList(gameObject);
        }
        else
        {
            autoAimer.RemoveFromList(gameObject);
        }
    }
}
