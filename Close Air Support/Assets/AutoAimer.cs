using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using UnityEngine.SocialPlatforms;

public class AutoAimer : MonoBehaviour
{
    public List<GameObject> inSightObject = new List<GameObject>();
    [SerializeField] private GameObject closetTarget;
    private Camera cam => Camera.main;

    [Range(0f,1f)]
    [SerializeField] private float aimRadius;
    
    public void AddToList(GameObject _object)
    {
        if (inSightObject.Contains(_object)) return;
      //  print("add" + _object);
        inSightObject.Add(_object);
    }

    public void RemoveFromList(GameObject _object)
    {
        if (!inSightObject.Contains(_object)) return;
     //   print("remove" + _object);
        inSightObject.Remove(_object);
    }

    private void Update()
    {
        //foreach(GameObject i in inSightObject)
        //{
        //    print(i.name + " " + Vector3.Distance(transform.position, i.transform.position));
        //}

        if (inSightObject.Count == 0)
        {
            closetTarget = null;
            return;
        }

        if(inSightObject.Count == 1)
        {
            closetTarget = inSightObject[0];
            return;
        }

        closetTarget = inSightObject.Aggregate((i1, i2) => getDistanceFromCenter(i1.transform.position) < getDistanceFromCenter(i2.transform.position) ? i1 : i2);

    }

    public GameObject ReturnClosetTarget()
    {
        if (closetTarget == null)
        {
            return null;
        }

        if(getDistanceFromCenter(closetTarget.transform.position) <= aimRadius)
        {
            print(getDistanceFromCenter(closetTarget.transform.position));
            return closetTarget;
        }
        else
        {
            return null;
        }
      
    }

    public float getDistanceFromCenter(Vector3 _object)
    {
        return Vector2.Distance(cam.WorldToViewportPoint(_object), new Vector2(0.5f, 0.5f));
    }

 
}
