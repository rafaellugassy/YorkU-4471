using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColliderPress : MonoBehaviour
{
    // To be attached to a button
    // Balls need to have the tag "Ball"

    Button b;

    void Start()
    {
        b = GetComponent<Button>();
        if (b == null)
            Debug.Log("No Button Found");
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
            b.onClick.Invoke();
    }
}
