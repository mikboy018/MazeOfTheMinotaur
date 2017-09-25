using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitScript : MonoBehaviour {


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Health"))
        {
            //Debug.Log("You died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
