using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class ReticleDrawer : MonoBehaviour
{
    private LineRenderer lineRenderer => GetComponent<LineRenderer>();
    [SerializeField] private AutoAimer autoAimer;
 
    // Update is called once per frame
    void Update()
    {
        if (autoAimer == null) return;
        DrawCircle(100, autoAimer.aimRadius * 10);
    }

    public void DrawCircle(int steps, float radius)
    {
        lineRenderer.positionCount = steps;
        
        for(int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress =(float)currentStep / steps;

            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);

            float x = xScaled * radius;
            float y = yScaled * radius;

            Vector3 currentPosition = new Vector3(x, y, 0);

            lineRenderer.SetPosition(currentStep, currentPosition);
        }
    }
}
