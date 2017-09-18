using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public Transform player;
    public Transform transportPad;

    
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerCollisionBox"))
        {
            player.transform.position = new Vector3(transportPad.position.x, player.position.y, transportPad.position.z);
        }
    }


}
