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
    }
}
