using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public string sceneName;
	public void GoToScene()
    {
        SceneManager.LoadScene(sceneName);
        DontDestroyOnLoad(GameObject.Find("MasterLogic"));
        //DontDestroyOnLoad(GameObject.Find("GameIndustryLogic"));
        //Checking to see if master logic ever gets destroyed...
        //GameObject.Find("MasterLogic").GetComponent<Counter>().keyCount++;
        //Debug.Log("Key Count is " + GameObject.Find("MasterLogic").GetComponent<Counter>().keyCount);
    }
}
