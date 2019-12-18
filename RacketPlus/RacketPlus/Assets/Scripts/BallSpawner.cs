using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public GameObject referenceBall;
    private Vector3 location;
    //private Vector3 size;
    private Quaternion rotation;
    // Start is called before the first frame update
    public void OnTriggerEnter()
    {
        
        
        location = referenceBall.transform.position;
        rotation = referenceBall.transform.rotation;
        //size = referenceBall.transform.localScale;
        GameObject cloneBall = Instantiate(ball, location, rotation);
        Physics.IgnoreCollision(cloneBall.GetComponent<Collider>(), referenceBall.GetComponent<Collider>());
    
    }
}
