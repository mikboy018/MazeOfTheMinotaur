using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOver : MonoBehaviour {

    public Transform startPoint;
    public GameObject player;
    public GameObject blueButtonRestore;
    public GameObject yellowButtonRestore;
    public GameObject sceneLogic;
    public GameObject Baddies;
    public GameObject[] BaddyList = new GameObject[6];
    public Text bossIsBack;


    public void ReturnToBeginning()
    {
        for(int i = 0; i < BaddyList.Length; i++)
        {
            BaddyList[i].SetActive(true);
            if (BaddyList[i].CompareTag("Boss"))
            {
                BaddyList[i].gameObject.GetComponent<Monster>().speed = BaddyList[i].gameObject.GetComponent<Monster>().speed * 2;
            }
            //Debug.Log(BaddyList[i].name + " is back");
        }
        player.transform.position = new Vector3(startPoint.position.x, player.transform.position.y, startPoint.position.z);
        blueButtonRestore.SetActive(true);
        yellowButtonRestore.SetActive(true);
        sceneLogic.gameObject.GetComponent<Score>().secondPass = true;
        bossIsBack.text = "Boss Status: ELIMINATED?";
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
