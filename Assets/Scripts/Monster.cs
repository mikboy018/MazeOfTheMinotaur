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

    void Awake()
    {
        //monsterBody = GetComponent<GameObject>();
        monsterNoise.Play();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
        if(Vector3.Distance(transform.position, target.position) >= minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            
        }
	}

}
