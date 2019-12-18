using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{
    // Start is called before the first frame update
    public bool selectable;
    public Transform menu;
    GameObject obj;

    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void act()
    {
        click.selected = gameObject;
        Debug.Log("you hit me");
        Destroy(GameObject.Find("objectMenu(Clone)"));
        Instantiate(menu, transform);
    }

}
