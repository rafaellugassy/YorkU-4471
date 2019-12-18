using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

	public TextMesh text;
	int points = 0;

    // Start is called before the first frame update
    void Start()
    {
		text.text = points + "";
    }

	void OnCollisionEnter(Collision collision){
		points++;
		text.text = points + "";
	}

}
