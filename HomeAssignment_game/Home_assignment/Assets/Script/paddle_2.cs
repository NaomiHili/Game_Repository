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

        float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16) - 8;

        Vector3 newPaddlePos = new Vector3(mousePosInUnits, gameObject.transform.position.y,
                                            gameObject.transform.position.z);

        // we needed to create a new variable for the new paddle position since we cannot change
        // one coordinate (e.g. x coordinate) on its own

        newPaddlePos.x = Mathf.Clamp(mousePosInUnits, -7.35f, 7.35f);

        gameObject.transform.position = newPaddlePos;

    }
}
