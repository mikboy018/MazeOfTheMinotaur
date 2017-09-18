using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour {

    public GameObject score;
    public GameObject masterLogic;
    public GameObject empty;
    public bool canCollect = false;

    public void CollectGem()
    {
        this.gameObject.SetActive(false);
        score.GetComponent<Score>().gemsCollected += 1;
        //Debug.Log("Time to remove gem");
        masterLogic.GetComponent<TreasureRemaining>().RemoveGem(this.gameObject, empty);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Proximity"))
        {
            canCollect = true;
        }
    }
}
