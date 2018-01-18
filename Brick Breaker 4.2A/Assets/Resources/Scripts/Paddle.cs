using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool auto = false;
    GameObject ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {

        // print(Input.mousePosition.x);
        if (!auto)
        {
            float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16) - 8;
            /*
             * Calculating the new Mouse position in game units since pixel units are returned
             * screen width of 800 pixels is equivalent to 16 game units
             * Since there is still an offset difference between the mouse and the paddle
             * The offset was noticed to be on the negative side and that is why we need to reduce
             * - 8 game units.
            */

            Vector3 newPaddlePos = new Vector3(mousePosInUnits, gameObject.transform.position.y,
                                                gameObject.transform.position.z);

            // we needed to create a new variable for the new paddle position since we cannot change
            // one coordinate (e.g. x coordinate) on its own


            newPaddlePos.x = Mathf.Clamp(mousePosInUnits, -7.35f, 7.35f);

            gameObject.transform.position = newPaddlePos;
            // setting our object's position (the paddle) to the new calculated position
        }
        else
        {
            if (ball == null)
            {
                ball = GameObject.Find("Ball");
            }

            Vector3 newPaddlePos = new Vector3(ball.transform.position.x, gameObject.transform.position.y,
                                               gameObject.transform.position.z);

            newPaddlePos.x = Mathf.Clamp(ball.transform.position.x, -7.35f, 7.35f);

            gameObject.transform.position = newPaddlePos;
        }
	}
}
