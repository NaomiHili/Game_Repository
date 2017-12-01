using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_2 : MonoBehaviour {
    float x = 0f;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 16) - 8;

        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, mousePosInUnits,
                                            gameObject.transform.position.z);

        // we needed to create a new variable for the new paddle position since we cannot change
        // one coordinate (e.g. x coordinate) on its own

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -3.35f, 3.35f);

        gameObject.transform.position = newPaddlePos;

    }
}
