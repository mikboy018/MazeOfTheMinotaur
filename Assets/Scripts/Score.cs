using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public bool keyCollected = false;

    public bool minotaurSlain = false;

    public bool secondPass = false;

    public int gemsCollected = 0;

    public int totalScore = 0;


    public void gemCollected()
    {
        gemsCollected = gemsCollected + 1;
        totalScore = totalScore + 100;
    }
    //update HUD when minotaur slain

    
}
