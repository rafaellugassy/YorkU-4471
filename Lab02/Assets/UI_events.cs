using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        lights = GameObject.FindGameObjectsWithTag("light");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform cube;
    bool grav = true, lightToggle = true;
    GameObject[] lights, boxes;
    public float gravValue = 5, lightIntensity = 1;
    public Slider slider, lightSlider;
    public void ToggleGravity()
    {
        grav = !grav;
        if (grav)
            Physics.gravity = new Vector3(0, -gravValue, 0);
        else
            Physics.gravity = Vector3.zero;

    }

    public void ChangeGravity()
    {
        gravValue = slider.value;
        Debug.Log(gravValue);
        Physics.gravity = new Vector3(0, -gravValue, 0);
    }

    public void ToggleLights()
    {
        lightToggle = !lightToggle;
        foreach (GameObject light in lights)
        {
            light.SetActive(lightToggle);
        }
    }

    public void ChangeLights()
    {
        lightIntensity = lightSlider.value;
        Debug.Log(lightIntensity);
        foreach (GameObject light in lights)
        {
            light.GetComponent<Light>().intensity = lightIntensity;
        }
    }

    public void Create()
    {
        Transform obj = Instantiate(cube,new Vector3(Random.Range(-40,40f), 5f, Random.Range(-40,40f)), new Quaternion());
        obj.RotateAroundLocal(obj.up, Random.Range(0, Mathf.PI));
        boxes = GameObject.FindGameObjectsWithTag("box");
    }

    public void Force()
    {
         foreach (GameObject box in boxes)
        {
            box.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-2000f,2000f), Random.Range(-2000f,2000f), Random.Range(-2000f,2000f)));
        }
    }

}
