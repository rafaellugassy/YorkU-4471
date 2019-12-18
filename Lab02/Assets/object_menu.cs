using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(1.3f, 0f, 0f);
        GameObject player = GameObject.Find("CenterEyeAnchor");
        gameObject.transform.LookAt(player.transform);
    }
}
