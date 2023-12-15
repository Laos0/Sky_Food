using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{

    public BodyManager bodyManager;

    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("apple"))
        {
            Debug.Log("You ate an apple");
        }

        if (other.gameObject.CompareTag("grape"))
        {
            Debug.Log("You ate a grape");
        }

        if (other.gameObject.CompareTag("pork"))
        {
            bodyManager.increaseFatMeter();
            Debug.Log("You ate a pork");
        }

        Destroy(other.gameObject); // Destroy the object that collided with the character
    }
}
