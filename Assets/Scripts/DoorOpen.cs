using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    public GameObject logic;
    public Animator door;
    
    

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.CompareTag("Proximity") && logic.GetComponent<Score>().keyCollected == true && !this.gameObject.CompareTag("BossKilledForExit"))
        {
            //open door 
            //Debug.Log("Opening Door");
            //door.Play();
            door.SetTrigger("Open Door");
            this.gameObject.GetComponent<Collider>().enabled = false;
        }
        if (other.gameObject.CompareTag("Proximity") && logic.GetComponent<Score>().keyCollected == true && this.gameObject.CompareTag("BossKilledForExit"))
        {
            //open door 
            //Debug.Log("Opening Door");
            //door.Play();
            //Debug.Log("Opening: " + this.gameObject.name);
            if (logic.GetComponent<Score>().minotaurSlain == true)
            {
                door.SetTrigger("Open Door");
                this.gameObject.GetComponent<Collider>().enabled = false;
            }
        }

    }

    

    
}
