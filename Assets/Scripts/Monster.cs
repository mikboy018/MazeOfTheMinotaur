using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour {

    public float speed;
    public Transform target;
    public float impact = 5;
    public AudioSource monsterNoise;
    public GameObject player;
    public GameObject score;
    

    void Awake()
    {
        //monsterBody = GetComponent<GameObject>();
        //monsterNoise.Play();
    }

	// Use this for initialization
	void Start () {
        //this.gameObject.GetComponent<BaddieWalkScript>().Walk();
  	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<BaddieWalkScript>().Walk();
	}


}
