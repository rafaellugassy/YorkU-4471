using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject racket;
    public GameObject referenceRacket;
    private Vector3 location;
    private Quaternion rotation;

    public void OnTriggerEnter()
    {
        location = referenceRacket.transform.position;
        rotation = referenceRacket.transform.rotation;

        GameObject cloneRacket = Instantiate(racket, location, rotation);
        Physics.IgnoreCollision(cloneRacket.GetComponent<Collider>(), referenceRacket.GetComponent<Collider>());
    }
}
