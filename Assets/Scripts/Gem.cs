using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour {

    public GameObject score;
    public GameObject sceneLogic;
    public GameObject empty;
    //public GameObject forNextLevel;
    public bool canCollect = false;
    public int gemNumber;

    public float speed = 20f;




    public void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    public void CollectGem()
    {
        this.gameObject.SetActive(false);
        score.GetComponent<Score>().gemsCollected += 1;
        //Debug.Log("Time to remove gem");
        sceneLogic.GetComponent<TreasureRemaining>().RemoveGem(this.gameObject, empty);
        //forNextLevel.GetComponent<GemFilter>().UpdateGems(gemNumber);

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Proximity"))
        {
            canCollect = true;
        }
    }
}
