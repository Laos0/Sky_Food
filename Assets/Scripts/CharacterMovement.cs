using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private float speed = 7.0f;
    private float screenWidth;

    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;

    }

    // Update is called once per frame
    void Update()
    {
        // move the character horizontally
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // keeping the character within the screen boudnaries
        Vector3 characterPos = Camera.main.WorldToScreenPoint(transform.position);
        characterPos.x = Mathf.Clamp(characterPos.x, 0 + (transform.localScale.x / 2), screenWidth - (transform.localScale.x / 2));
        transform.position = Camera.main.ScreenToWorldPoint(characterPos);
    }
}
