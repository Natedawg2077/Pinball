using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    //Declaring Variables
    int score = 0;
    public Text scoreText;
    public Text MessageText;

    // Start is called before the first frame update
    void Start()
    {
        //Giving the text objects a start value
        string scoreText = "Score: " + score;
        string MessageText = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D otherObject)
    {
        //Says in the console when the ball collides with an object and what object it collided with
        Debug.Log("Ball has collided with " + otherObject.gameObject.name);

        //Increases the score when the ball touches another object
        score++;

        //Updates the score
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        //Prints in the console "Game Over!" when the ball touches a trigger collider
        Debug.Log("Game Over!");

        //Prints in the console when the game is over
        MessageText.text = "Game Over!";
    }
}
