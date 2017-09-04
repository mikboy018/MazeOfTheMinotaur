using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockScript : MonoBehaviour
{
    public bool collectionTrue;
    public Scene scene;
    public string title;
    public AudioSource narrator;
    public void Awake()
    {
        scene = SceneManager.GetActiveScene();
        title = scene.name;
    }
    
    private void Update()
    {
        ArtifactCollected();
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("PlayButton");
        if (collectionTrue == true)
        {
            foreach (GameObject go in gameObjectArray)
            {
                go.GetComponent<Button>().interactable = true;
            }
        }
    }

    public bool ArtifactCollected()
    {
        if (title == "GameIndustry" & GameObject.Find("MasterLogic").GetComponent<Counter>().gamesDone > 0)
        {
            collectionTrue = true;
        }
        if (title == "Movies" & GameObject.Find("MasterLogic").GetComponent<Counter>().moviesDone > 0)
        {
            collectionTrue = true;
        }
        if (title == "AR" & GameObject.Find("MasterLogic").GetComponent<Counter>().arDone > 0)
        {
            collectionTrue = true;
        }
        if (title == "CAD" & GameObject.Find("MasterLogic").GetComponent<Counter>().cadDone > 0)
        {
            collectionTrue = true;
        }
        if (title == "Education" & GameObject.Find("MasterLogic").GetComponent<Counter>().eduDone > 0)
        {
            collectionTrue = true;
        }

        return collectionTrue;
    }

    public void playMovie()
    {
        MediaPlayer mp = this.GetComponentInChildren<MediaPlayer>();
        mp.Play();
        narrator.Play();        
    }
}
  
