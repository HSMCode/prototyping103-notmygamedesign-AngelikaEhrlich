using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = .1f;
    public int score;       //players score
    public int lives;       //this is the number of lives the player has

    private void Start()
    {
        score = 0;
        lives = 5;
    }

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

    // ScorePoints will be called from the FallingGoldScript when a collision occures between the player and the gold object
    void ScorePointsGold()
    {
        //add points to the score
        score += 1;
    }

    // ScorePoints will be called from the FallingCoalScript when a collision occures between the player and the coal object
    void ScorePointsCoal()
    {
        //subtract points to the score
        score -= 1;
    }

    // LoseLife will be called from the FallingCoalScript when a collision occures between the player and the coal object
    void LoseLife()
    {
        lives--;    //subtract 1 from lives

        //check to see if we have are out of lives
        if(lives < 1)
        {
            //out of lives
            GameOver();
        }
    }

    void GameOver()
    {
        //Make player disappear and be disabled
        gameObject.SetActive(false);
    }

}
