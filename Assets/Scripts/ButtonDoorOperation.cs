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
        //Debug.Log(other.gameObject.name + " stepped on: " + this.gameObject.name);
        if (other.gameObject.CompareTag("PlayerCollisionBox") && logic.GetComponent<Score>().minotaurSlain == true)
        {
            //disable other door buttons
            otherButton.gameObject.SetActive(false);
            //open door
            /*
            door1.SetTrigger("Open Door");
            if (this.name != "YellowDoorTrigger")
            {
                door2.SetTrigger("Open Door");
            }
            if (this.name == "YelloDoorTrigger")
            {
                door1.gameObject.SetActive(false);
                door2.gameObject.SetActive(false);
            }*/

            door1.gameObject.SetActive(false);
            door2.gameObject.SetActive(false);
            
        }

    }
}
