using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    public float speed;
    public Transform target;
    public float minDist;
    public float maxDist;
    public AudioSource monsterNoise;
    public float time;
    public GameObject player;
    

    void Awake()
    {
        //monsterBody = GetComponent<GameObject>();
        monsterNoise.Play();
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
