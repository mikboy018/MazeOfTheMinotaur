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
    //public AudioSource narrator;
    public void Awake()
    {
        scene = SceneManager.GetActiveScene();
        title = scene.name;
    }
    
    private void Update()
    {/*
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("PlayButton");
        if (collectionTrue == true)
        {
            foreach (GameObject go in gameObjectArray)
            {
                go.GetComponent<Button>().interactable = true;
            }
        }*/
    }

    public void playMovie()
    {
        MediaPlayer mp = this.GetComponentInChildren<MediaPlayer>();
        mp.Play();
        //narrator.Play();        
    }
}
  
