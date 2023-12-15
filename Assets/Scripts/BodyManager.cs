using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyManager : MonoBehaviour
{
    public CharacterMovement characterMovement;
    public float fatMeter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseFatMeter()
    {
        fatMeter += .3f;
        Vector3 currentFatMeter = transform.localScale;
        currentFatMeter.x += fatMeter;
        transform.localScale = currentFatMeter;

        // update the character movement
        characterMovement.speed -= 1;
    }
}
