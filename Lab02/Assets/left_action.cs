using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_action : action
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void act()
    {
        Debug.Log("left left left " + click.selected.name);
        click.selected.transform.RotateAround(click.selected.transform.up, -0.1f);

    }
}