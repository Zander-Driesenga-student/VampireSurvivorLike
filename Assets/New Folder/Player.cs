using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2f;

    void Update()
    {
        /*if (player != null) { return; }*/

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;
        

        /*transform.Translate(movement * moveSpeed * Time.deltaTime);
        if (Input.GetKeyUp("Horizontal") || Input.GetKeyUp("Vertical"))
        {
            gameObject.transform.position = Vector2.zero;
        }*/

    }
}
