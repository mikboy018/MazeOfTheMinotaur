using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemFilter : MonoBehaviour
{

    public GameObject sceneLogic;

    public GameObject[] gems;

    public GameObject treasure;

    public bool[] filteredGems = new bool[8];

    public bool secondPass;

    private void Start()
    {
        gems = sceneLogic.gameObject.GetComponent<TreasureRemaining>().gems;
        
    }

    private void Update()
    {
        gems = sceneLogic.gameObject.GetComponent<TreasureRemaining>().gems;
    }

    /*
    public void FilterIn()
    {
        gems = new GameObject[treasure.transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            gems[i] = transform.GetChild(i).gameObject;
            if (!gems[i].CompareTag("Collectible"))
            {
                //gems[i].SetActive(false);
                filteredGems[i] = false;
            }
            if (gems[i].CompareTag("Collectible"))
            {
                filteredGems[i] = false;
            }
        }
    }
    */

    public void UpdateGems(int i)
    {
        filteredGems[i] = true;
    }
}
	
