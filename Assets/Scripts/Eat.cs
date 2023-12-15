using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(other.gameObject); // Destroy the object that collided with the character

        Debug.Log("EAT");
    }
}
