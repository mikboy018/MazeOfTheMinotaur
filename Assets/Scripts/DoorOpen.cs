using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    public GameObject logic;
    public Animator door;
    

    private void OnTriggerStay(Collider other)
    {
        if (other.name != "Floor")
        {
            Debug.Log(other.name);
        }
        if (other.gameObject.CompareTag("Proximity") && logic.GetComponent<Score>().keyCollected == true)
        {
            //open door 
            Debug.Log("Opening Door");
            //door.Play();
            door.SetTrigger("Open Door");
            this.gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    
}
