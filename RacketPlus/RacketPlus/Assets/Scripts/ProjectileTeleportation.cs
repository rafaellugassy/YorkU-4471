using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTeleportation : MonoBehaviour
{
    // Script to be attached to the ball
    // Sports equipment have to have the tag "Racket"
    // Floor needs to have the tag "Floor"
    // PlayerToTeleport also includes the table and equipment

    Transform playerToTeleport;
    Transform ovrPlayer;
    OVRPlayerController pc;
    CharacterController cc;

    bool readyToTeleport;

    public Vector3 tpPos;

    bool holdPos;
    float holdPosF = 0.1f;

    void Start()
    {
        playerToTeleport = GameObject.FindGameObjectWithTag("Player").transform;
        ovrPlayer = playerToTeleport.Find("OVRPlayerController");
        //pc = ovrPlayer.GetComponent<OVRPlayerController>();
        cc = ovrPlayer.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (holdPos)
        {
            //pc.enabled = false;
            cc.enabled = false;
            ovrPlayer.localPosition = new Vector3(0, 0.7f, 0);
            holdPosF -= Time.deltaTime;
            if (holdPosF <= 0)
            {
                holdPosF = 0.1f;
                //pc.enabled = true;
                cc.enabled = true;
                holdPos = false;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Racket"))
        {
            readyToTeleport = true;
        }
        if (collision.gameObject.CompareTag("Ground") && readyToTeleport)
        {
            playerToTeleport.position = new Vector3(collision.GetContact(0).point.x, playerToTeleport.position.y, collision.GetContact(0).point.z);
            

            holdPos = true;
            readyToTeleport = false;
        }
    }
}
