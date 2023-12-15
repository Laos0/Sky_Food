using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    // This script should be attached to the plane object

    // OnTriggerEnter is called when another collider enters this collider (the plane)
    private void OnTriggerEnter(Collider other)
    {
        // Example: Make the falling object disappear when it touches the plane
        Destroy(other.gameObject); // Destroy the object that collided with the plane

        Debug.Log("HIT");
    }
}
