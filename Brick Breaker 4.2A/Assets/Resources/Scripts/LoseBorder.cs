using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBorder : MonoBehaviour {

    LevelManager levelManager = new LevelManager(); // created an instance/copy of Level manager
    int lives = 0;
    public Text livesText;
    GameObject ballPrefab;
    GameObject ball;    
    Vector3 ballInitialPos;

    GameObject paddle;
    Vector3 paddleInitialPos;

    // Use this for initialization
    void Start () {
        lives = 3;
        livesText.text = "Lives: 3";
        ball = GameObject.Find("Ball");
        ballPrefab = Resources.Load("Prefabs/Ball") as GameObject;
        ballInitialPos = ball.transform.position;

        paddle = GameObject.Find("Paddle");
        paddleInitialPos = paddle.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives--;
        if (lives > 0)
        {
            livesText.text = "Lives: " + lives;
            Destroy(collision.gameObject);
            Instantiate(ballPrefab, ballInitialPos, Quaternion.identity);
            paddle.transform.position = paddleInitialPos;
        }
        else
        {
            levelManager.LoadNewScene("Lose");
        }
    }

    
}
