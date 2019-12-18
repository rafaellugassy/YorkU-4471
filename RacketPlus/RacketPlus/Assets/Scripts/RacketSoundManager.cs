using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketSoundManager : MonoBehaviour {

    public AudioSource audiosrc;
    public AudioClip clip_rackethitground;
    public AudioClip clip_rackethittable;
    public AudioClip clip_rackethitball;
    public AudioClip clip_hitdef;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Ground"))
        {
            audiosrc.clip = clip_rackethitground;
            audiosrc.Play();
        }
        else if (collision.transform.tag.Equals("ball"))
        {
            audiosrc.clip = clip_rackethitball;
            audiosrc.Play();
        }
        else if (collision.transform.tag.Equals("table"))
        {
            audiosrc.clip = clip_rackethittable;
            audiosrc.Play();
        }
        else
        {
            audiosrc.clip = clip_hitdef;
            audiosrc.Play();
        }

    }
}
