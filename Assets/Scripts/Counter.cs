using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**This is built from the Project 3 MazeCounter.cs file
 * This is designed to track each artifact that obtained to 
 * better ensure the player has visited each exhibit.
 * 
 * Scene - Artifact:
 * GameIndustry - A Blue Key
 * MovieIndustry - A Movie Reel
 * VR/AR Cad - A Blueprint
 * AR Tech Manuals - An AR headset or a book
 * Medical/Technical Training - A medical device
 * 
 * 27 JUN 2017 - Mike Boyer
 **/

public class Counter : MonoBehaviour
{
    public int count;
    public int gamesDone;
    public int moviesDone;
    public int cadDone;
    public int arDone;
    public int eduDone;
    
    //Return the total number of visitors
    public int GetTotalVisted()
    {
        /*
        if(GameObject.Find("GameIndustryLogic").GetComponent<GameIndustryComplete>().gameIndustryDone == true && gamesDone < 1)
        {
            gamesDone++;
        }*/
        count = gamesDone + moviesDone + cadDone + arDone + eduDone;
        return count;
    }
    
}
  