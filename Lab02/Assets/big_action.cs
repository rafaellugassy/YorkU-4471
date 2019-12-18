using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big_action : action
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
        Debug.Log("big big big " + click.selected.name);
        click.selected.transform.localScale += new Vector3 (1,1,1);
        
    }
}
