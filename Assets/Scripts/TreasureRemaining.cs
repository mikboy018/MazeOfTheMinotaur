using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureRemaining : MonoBehaviour {

    public GameObject[] gems;
    
    
	void Start () {
        for(int i = 0; i < gems.Length; i++)
        {
            if (!gems[i].CompareTag("Collectible"))
            {
                gems[i].SetActive(false);
            }
        }
	}

    public void RemoveGem(GameObject gem, GameObject empty)
    {
        for (int i = 0; i < gems.Length; i++)
            {
            if (gems[i].Equals(gem))
            {
                //Debug.Log("removing gem: " + gems[i].gameObject.name);
                gems[i] = empty;
            }
                
            }
    }

}
