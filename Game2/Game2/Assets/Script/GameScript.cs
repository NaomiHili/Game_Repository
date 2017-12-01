using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    int num1 = 50;

    // Use this for initialization
    void Start () {
        print("Welcome to number game.");
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow is pressed!");
            num1 = num1 + 1;
            print(num1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow is pressed!");
            num1 = num1 - 1;
            print(num1);
        }



    }
}
