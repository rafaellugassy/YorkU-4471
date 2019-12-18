using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Cannon : MonoBehaviour
{
	public GameObject point;
	public Rigidbody ball;
	public GameObject fireLoc;
	public Text text;
    // Start is called before the first frame update

	int force = 1000;

    void Start()
    {
		text.text = force + "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            XRSettings.enabled = !XRSettings.enabled;
        }
       // if (!XRSettings.enabled) { 
            if (Input.GetKey(KeyCode.A)) {
                transform.RotateAround(transform.position, point.transform.up, -1);
            } else if (Input.GetKey(KeyCode.D)) {
                transform.RotateAround(transform.position, point.transform.up, 1);
            } if (Input.GetKey(KeyCode.S)) {
            transform.Rotate(1, 0, 0);
            } else if (Input.GetKey(KeyCode.W)) {
            transform.Rotate(-1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                Rigidbody ballInstance;
                ballInstance = Instantiate(ball, fireLoc.transform.position, fireLoc.transform.rotation);
                ballInstance.AddForce(fireLoc.transform.forward * force);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                force += 50;
                text.text = force + "";
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                force -= 50;
                text.text = force + "";
            }
       // }
       // else
       // {
          /*  if (OVRInput.GetDown(OVRInput.Axis1D.SecondaryIndexTrigger))
            {
                Rigidbody ballInstance;
                ballInstance = Instantiate(ball, fireLoc.transform.position, fireLoc.transform.rotation);
                ballInstance.AddForce(fireLoc.transform.forward * force);
            }*/
       // }
    }
}
