using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandscapeManager : MonoBehaviour
{
    // To beattached to the LandscapeManager gameobject

    public GameObject[] Scenes = new GameObject[1];

    // Starts at 0
    int sceneIndex;

    void Start()
    {
        foreach(GameObject s in Scenes)
        {
            s.SetActive(false);
        }
        Scenes[sceneIndex].SetActive(true);
    }
    
    public void NextScene()
    {
        Debug.Log("Next Scene");
        Scenes[sceneIndex].SetActive(false);
        sceneIndex++;
        if (sceneIndex >= Scenes.Length)
            sceneIndex = 0;
        Scenes[sceneIndex].SetActive(true);
    }

    public void PrevScene()
    {
        Debug.Log("Previous Scene");
        Scenes[sceneIndex].SetActive(false);
        sceneIndex--;
        if (sceneIndex < 0)
            sceneIndex = Scenes.Length - 1;
        Scenes[sceneIndex].SetActive(true);
    }
}
