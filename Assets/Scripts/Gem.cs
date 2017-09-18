using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour {

    public GameObject score;

    public void CollectGem()
    {
        this.gameObject.SetActive(false);
        score.GetComponent<Score>().gemsCollected += 1;

    }
}
