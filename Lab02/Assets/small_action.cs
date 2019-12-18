using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_action : action
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
        Debug.Log("small small small " + click.selected.name);
        if (click.selected.transform.localScale.x > 1f && click.selected.transform.localScale.y > 1f && click.selected.transform.localScale.z > 1f)
        click.selected.transform.localScale -= new Vector3 (1,1,1);
        
    }
}
