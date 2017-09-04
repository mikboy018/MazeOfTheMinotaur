using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPostText : MonoBehaviour
{
    Text scoreMsg;


    void Update()
    {
        int roomsComplete = GameObject.Find("MasterLogic").GetComponent<Counter>().GetTotalVisted();
        //add keyCount and coinCount to scoreMsg
        scoreMsg = GetComponent<Text>();
        scoreMsg.text = "You have completed " + roomsComplete + " out of 5 rooms! \n Click the door to exit!";

    }

    public void OnSignClick()
    {
        // Reset the scene when the user clicks the sign post
        Application.Quit();
    }
}