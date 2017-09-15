using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkRay : MonoBehaviour {
    // Player
    public GameObject player;
    public Collider playerCollider;
    public GameObject movement;
    public GameObject gun;
    

    // Wall
    public GameObject wall;

    // Shrunk Height
    private Vector3 ShortHeight = new Vector3(0, -2f, 0);
    private Vector3 ShortColliderHeight = new Vector3(0, 0, 0);
    private Vector3 ShrunkGun = new Vector3(.1f, .1f, .1f);

    // Tall Height
    private Vector3 NormalHeight = new Vector3(0, 1f, 0);



    private void OnTriggerStay(Collider other)
    {
        
        // When the player moves to the shrink pad, they are shrunk
        if (this.gameObject.GetComponentInChildren<ShrinkCapable>() && movement.GetComponent<RaycastMovement>().isShrunk == false)
        {
            if (this.gameObject.GetComponent<ShrinkCapable>().canShrink == true && other.gameObject.GetComponent<Collider>().Equals(playerCollider))
            {
                Debug.Log("Shrinking player!");
                player.transform.position += ShortHeight;
                // While shrunk, the box collider is disabled, and the player can walk under
                wall.GetComponent<Collider>().enabled = false;
                playerCollider.gameObject.transform.localPosition = ShortColliderHeight;
                gun.transform.localScale = ShrunkGun;
                movement.GetComponent<RaycastMovement>().isShrunk = true;
            }
        }
        if (this.gameObject.GetComponentInChildren<GrowCapable>())
        {
            // When the player moves to the grow pad, they can grow, and the box collider
            if (this.gameObject.GetComponent<GrowCapable>().canGrow == true && other.gameObject.GetComponent<Collider>().Equals(playerCollider))
            {
                // restore player height and collider
                player.transform.position += NormalHeight;
                wall.GetComponent<Collider>().enabled = true;
                movement.GetComponent<RaycastMovement>().isShrunk = false;
            }
        }
    }



}
