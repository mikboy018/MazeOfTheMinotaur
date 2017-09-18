using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public GameObject score;
    public Text gemsStatus;
    public Text totalScoreStatus;


    //local variables
    private bool keyCollected;
    private bool minotaurSlain;
    private int gemsCollected;
    private int totalScore;


    // Use this for initialization
    void Start () {
        keyCollected = score.gameObject.GetComponent<Score>().keyCollected;
        minotaurSlain = score.gameObject.GetComponent<Score>().minotaurSlain;
        gemsCollected = score.gameObject.GetComponent<Score>().gemsCollected;
        totalScore = score.gameObject.GetComponent<Score>().totalScore;
	}
	
	// Update is called once per frame
	void Update () {
		if(keyCollected != score.gameObject.GetComponent<Score>().keyCollected)
        {
            totalScore = +200;
            totalScoreStatus.text = "Total Score: " + totalScore.ToString();

        }
        /*if(minotaurSlain != score.gameObject.GetComponent<Score>().minotaurSlain)
        {

        }*/
        if(gemsCollected != score.gameObject.GetComponent<Score>().gemsCollected)
        {
            gemsCollected = score.gameObject.GetComponent<Score>().gemsCollected;
            gemsStatus.text = "Gems Collected: " + gemsCollected.ToString();
        }
        if (totalScore != score.gameObject.GetComponent<Score>().totalScore)
        {
            totalScore = score.gameObject.GetComponent<Score>().totalScore;
            totalScoreStatus.text = "Total Score: " + totalScore.ToString();
        }


	}
}
