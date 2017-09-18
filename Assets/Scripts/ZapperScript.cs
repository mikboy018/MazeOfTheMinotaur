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
    //public Transform monster;
    public GameObject poof;
    public AudioSource gunFire;
    public AudioSource monsterBoom;
    public int zapperDamage = 25;
    public GameObject score;
    
   

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
            //Debug.Log("Bang!");
                      
        }
    }


    void zap()
    {
        //upon clicking a monster, enable the gun to fire (tag - ZapBlast)
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            //Debug.Log(hit.transform.name);
            if(hit.transform.CompareTag("Monster"))
            {
                Destroy(hit.transform.gameObject);
                Object.Instantiate(poof, hit.transform.position, Quaternion.Euler(-90f, 0f, 0f));
                //Debug.Log("Got him!");
                StartCoroutine(flash());
                //StartCoroutine(disableWeapon());
                monsterBoom.Play();
                score.GetComponent<Score>().totalScore += 200;
                Debug.Log("Score: " + score.GetComponent<Score>().totalScore);
            }
            if (hit.transform.CompareTag("Boss"))
            {
                hit.transform.gameObject.GetComponent<BossStatus>().bossHealth = hit.transform.gameObject.GetComponent<BossStatus>().bossHealth - zapperDamage;
                //Debug.Log("Boss health is now: " + hit.transform.gameObject.GetComponent<BossStatus>().bossHealth);
                StartCoroutine(flash());
                if (hit.transform.gameObject.GetComponent<BossStatus>().bossHealth == 0)
                {
                    Destroy(hit.transform.gameObject);
                    Object.Instantiate(poof, hit.transform.position, Quaternion.Euler(-90f, 0f, 0f));
                    //Debug.Log("Got him!");
                    StartCoroutine(flash());
                    //StartCoroutine(disableWeapon());
                    monsterBoom.Play();
                    score.GetComponent<Score>().totalScore += 1000;
                    //sets the condition to unlock green exit door and enable the blue and yellow buttons
                    score.GetComponent<Score>().minotaurSlain = true;
                    //Debug.Log("Score: " + score.GetComponent<Score>().totalScore);
                }
            }
            if (hit.transform.CompareTag("Collectible"))
            {
                if(hit.transform.name == "Key")
                {
                    hit.collider.gameObject.GetComponentInParent<Key>().OnKeyClicked();
                }
                if(hit.transform.name != "Key")
                {
                    if (hit.transform.gameObject.GetComponent<Gem>().canCollect == true)
                    {
                        hit.collider.gameObject.GetComponent<Gem>().CollectGem();
                    }
                }
                
            }
            if (hit.transform.CompareTag("movementCapable"))
            {
                stopBlast();
            }
            if (!hit.transform.CompareTag("movementCapable") & !hit.transform.CompareTag("Collectible"))
            {
                GunBlast();
                //Debug.Log("Missed!");
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
        //Debug.Log("no more blast");
    }

    public IEnumerator flash()
    {
        yield return new WaitForSeconds(waitTime);
        //Debug.Log("waiting");
        stopBlast();
    }
    
}
