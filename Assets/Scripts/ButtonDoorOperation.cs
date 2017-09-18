using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorOperation : MonoBehaviour {
    public GameObject logic;
    public GameObject otherButton;
    public Animator door1;
    public Animator door2;


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("You stepped on: " + this.gameObject.name + " - triggered by: " + other.gameObject.name);
        if (other.gameObject.CompareTag("PlayerCollisionBox") && logic.GetComponent<Score>().minotaurSlain == true)
        {
            
            //open door
            door1.SetTrigger("Open Door");
            door2.SetTrigger("Open Door");
            //disable other doors
            otherButton.gameObject.SetActive(false);
        }

    }
}
