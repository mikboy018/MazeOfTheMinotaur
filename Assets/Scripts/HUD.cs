using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public GameObject score;
    public GameObject boss;
    public Text gemsStatus;
    public Text totalScoreStatus;
    public Text bossStatus;


    //local variables
    private bool keyCollected;
    private bool minotaurSlain = false;
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
            keyCollected = score.gameObject.GetComponent<Score>().keyCollected;
            score.gameObject.GetComponent<Score>().totalScore += 200;
            totalScoreStatus.text = "Total Score: " + totalScore.ToString();

        }
        /*if(minotaurSlain != score.gameObject.GetComponent<Score>().minotaurSlain)
        {

        }*/
        if(gemsCollected != score.gameObject.GetComponent<Score>().gemsCollected)
        {
            gemsCollected = score.gameObject.GetComponent<Score>().gemsCollected;
            score.gameObject.GetComponent<Score>().totalScore += 100;
            gemsStatus.text = "Gems Collected: " + gemsCollected.ToString() + " of 8";
        }
        if (totalScore != score.gameObject.GetComponent<Score>().totalScore)
        {
            totalScore = score.gameObject.GetComponent<Score>().totalScore;
            totalScoreStatus.text = "Total Score: " + totalScore.ToString();
        }
        if (minotaurSlain != score.gameObject.GetComponent<Score>().minotaurSlain)
        {
            minotaurSlain = score.gameObject.GetComponent<Score>().minotaurSlain;
        }
        if (minotaurSlain == score.gameObject.GetComponent<Score>().minotaurSlain)
        {
            if (minotaurSlain == false)
            {
                bossStatus.text = "Boss Status: ALIVE, and hunting. Health: " + boss.gameObject.GetComponent<BossStatus>().bossHealth;
            }
            if (minotaurSlain == true)
            {
                bossStatus.text = "Boss Status: ELIMINATED";
            }
        }


	}
}
