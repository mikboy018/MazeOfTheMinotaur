using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    //public Door exitDoor;
    public AudioClip keySound;
    public bool keyCollected = false;
    public float speed = 10f;
    //Placeholder for Door Script



    public void Update()
	{
        //Not required, but for fun why not try adding a Key Floating Animation here :)
        // ^-- exactly what I was planning!
        //I'm using numbers here as I only plan to have one key-like object... I'd totally make my 
        //own Vector3 object for reusability had it been required...
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

	public void OnKeyClicked()
	{
        
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Vector3 keyLocation = transform.position;
        Object.Instantiate(keyPoof, keyLocation, Quaternion.Euler(-90f, 0f, 0f));
        AudioSource.PlayClipAtPoint(keySound, transform.position);
        // Call the Unlock() method on the Door
        //exitDoor.Unlock();
        // Set the Key Collected Variable to true
        keyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Object.DestroyImmediate(this.gameObject, true);
        //print("Removed key!);
        RemoveKey();
        //next ill figureout how to have a counter for keys and coins
        GameObject.Find("Counter").GetComponent<Counter>().count++;
    }
    public IEnumerator RemoveKey()
    {
        yield return new WaitForSeconds(5);
        Object.DestroyImmediate(keyPoof, true);
        //print("keyPoof removed!");
    }

}