using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyManager : MonoBehaviour
{
    public CharacterMovement characterMovement;
    public float fatMeter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO: need to give this method below arguments deciding what food was eaten

    public void increaseFatMeter()
    {
        fatMeter += .3f; // TODO: needs to be adjusted based on the food
        Vector3 currentFatMeter = transform.localScale;
        currentFatMeter.x += fatMeter;
        transform.localScale = currentFatMeter;

        // update the character movement
        characterMovement.speed -= 1f;
    }

    public void decreaseFatMeter()
    {
        fatMeter -= .3f; // TODO: needs to be adjusted based on the food
        Vector3 currentFatMeter = transform.localScale;
        currentFatMeter.x += fatMeter;
        transform.localScale = currentFatMeter;

        // update the character movement
        characterMovement.speed -= 1f;
    }

    private bool isFatMeterMax()
    {
        if (fatMeter < 5f)
        {
            return false;
        }

        return true; // return true if fatmeter is max;
    }
}
