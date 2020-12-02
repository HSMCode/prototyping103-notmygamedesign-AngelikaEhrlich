using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = .1f;

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(xDirection, 0);

        transform.position += moveDirection * speed;

        //Check to see if the player has left the left edge of the screen
        if (transform.position.x < -8.25f)
        {
            //Move the player back to the edge of the screen
            transform.position = new Vector3(-8.25f, transform.position.y);
        }

        //Check to see if the player has left the right edge of the screen
        if (transform.position.x > 8.25f)
        {
            //Move the player back to the edge of the screen
            transform.position = new Vector3(8.25f, transform.position.y);
        }
    }
}
