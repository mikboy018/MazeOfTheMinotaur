using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ZapperScript : MonoBehaviour {

    public Camera fpsCam;
    public float waitTime;
    public GameObject[] zapperArray;
    public GameObject[] zapBlastArray;
    public Transform weapon;
    public Transform monster;
    public GameObject poof;
    public AudioSource gunFire;
    public AudioSource monsterBoom;
   

    // Use this for initialization
    void Start() {
        string type = "ZapBlast";
        zapBlastArray = GameObject.FindGameObjectsWithTag(type);
        foreach (GameObject go in zapBlastArray)
        {
            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1"))
        {
            
            zap();
            Debug.Log("Bang!");
                      
        }
    }


    void zap()
    {
        //upon clicking a monster, enable the gun to fire (tag - ZapBlast)
        //when monster gone, destroy Zapper and ZapBlast
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.name == "RobotMonster")
            {
                Destroy(GameObject.Find("RobotMonster"));
                Object.Instantiate(poof, monster.position, Quaternion.Euler(-90f, 0f, 0f));
                Debug.Log("Got him!");
                StartCoroutine(flash());
                StartCoroutine(disableWeapon());
                monsterBoom.Play();
            }
            if (hit.transform.name != "Floor")
            {
                GunBlast();
                Debug.Log("Missed!");
            }
        }
    }

    void GunBlast()
    {
        
        foreach (GameObject go in zapBlastArray)
        {
            go.SetActive(true);
        }
        gunFire.Play();

        StartCoroutine(flash());
       /*
        foreach (GameObject go in zapBlastArray)
        {
            go.SetActive(false);
        }
        Debug.Log("no more blast"); */
    }

    void stopBlast()
    {
        foreach (GameObject go in zapBlastArray)
        {
            go.SetActive(false);
        }
        Debug.Log("no more blast");
    }

    public IEnumerator flash()
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("waiting");
        stopBlast();
    }
    public IEnumerator disableWeapon()
    {
        zapperArray = GameObject.FindGameObjectsWithTag("Zapper");
        foreach (GameObject go in zapperArray)
        {
            yield return new WaitForSeconds(waitTime*5f);
            go.transform.position += new Vector3(weapon.position.x, -.125f, weapon.position.z);
            go.SetActive(false);
        }
    }
}
