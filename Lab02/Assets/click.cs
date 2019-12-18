
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{

    public static GameObject selected;
    bool buttonPress = false;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Debug.DrawRay(transform.position, transform.forward, Color.black, 2f);
        /*
        if (Input.GetMouseButtonUp(0))
        {
            buttonPressed();
        }
        */
        if (!buttonPress && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger,OVRInput.Controller.Touch) > 0.5)
        {
            buttonPress = true;
            buttonPressed();
        }

        else if (buttonPress && OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger,OVRInput.Controller.Touch) < 0.5)
        {
            buttonPress = false;
        }


        
      /*  if (SteamVR_Input._default.inActions.pressTrigger.GetStateDown(SteamVR_Input_Sources.Any))
        {
            Debug.Log("yo dawg");
        }*/
    }

    void buttonPressed()
    {
        // get object hit
        if (Physics.Raycast(transform.position,transform.forward,out hit, 10f))
            Debug.Log("hit " + hit.transform.name);

        // perform hit action
        
        hit.collider.gameObject.GetComponent<action>().act();

        Debug.Log("test");
    }
}
