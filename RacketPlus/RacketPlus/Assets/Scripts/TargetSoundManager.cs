using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSoundManager : MonoBehaviour
{

    public AudioSource audiosrc;
    public AudioClip Clip_ballhittarget;
    public GameObject ParticleHit;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Ball"))
        {
            audiosrc.clip = Clip_ballhittarget;
            audiosrc.Play();
            Destroy(Instantiate(ParticleHit, transform.position, transform. rotation, null),5);
        }
    }

}
