using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour
{
	public float speed = 50.0f;
	public Camera moveCamTo;
	//public Camera freeCamera;
	public GameObject stukaBody;
	public float turnWithoutTilt = 0.0f; //FOR Q AND E MOVEMENT
	public float planeTurnSpeed = 0.0f;

	void Start()
	{
		//DISABLE MOUSE AND MAKE IT INVISIBLE
		Cursor.lockState = CursorLockMode.Locked;

		//moveCamTo.enabled = true;
		//freeCamera.enabled = false;
	}

	void Update()
	{
		//PLANE SPEED
		transform.position += transform.forward * Time.deltaTime * speed;
		speed -= transform.forward.y * Time.deltaTime * 50.0f;

		//SMARTER WAY OF SETTING MIN AND MAX SPEED
		speed = Mathf.Clamp(speed, 50, 100);

		//INCREASE/DECREASE PLANE SPEED
		if (Input.GetKey(KeyCode.LeftShift))
		{
			speed = speed + 1;
		}

        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = speed - 1;
        }


        /*if(speed < 50.0f)
		{
			speed = 50.0f;
		}

		if(speed > 300.0f)
		{
			speed = 300.0f;
		}*/

        //PLANE TURNING
        transform.Rotate(Input.GetAxis("Vertical") * Time.deltaTime * planeTurnSpeed, 0.0f, -Input.GetAxis("Horizontal") * Time.deltaTime * planeTurnSpeed);

		if(Input.GetKey(KeyCode.Q))
		{
			transform.Rotate(0f, -turnWithoutTilt, 0f);
		}

		if (Input.GetKey(KeyCode.E))
		{
			transform.Rotate(0f, turnWithoutTilt, 0f);
		}

		//float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

		/*if(terrainHeightWhereWeAre > transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, terrainHeightWhereWeAre, transform.position.z);
		}*/
	}
}