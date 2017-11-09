using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    //Global Veriables.
    int min = 0;
    int max = 0;
    int guess = 0;

    // Use this for initialization
    void Start () {

        StartGame();

    }
	
	// Update is called once per frame
	void Update () {

        //these are two methods of get an input they you the same thing
        if (Input.GetKeyDown("up"))
        {
            print("Up Arrow pressed!");
            min = guess + 1;
            NextGuess();
        }

        // I prefer this method
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow is pressed!");
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter is pressed");
            print("I Guessed your number!");
            StartGame();
        }
	}

    void StartGame()
    {
        min = 1;
        max = 1000;
        //guess = 500;

        print("Welcom to Number Wizard!");
        print("Pick an number from 1 to 1000 and dont tell me what it is!");

        NextGuess();
    }

    void NextGuess()
    {
        guess = (min + max) / 2;

        print("Is the number higher, lower or equal to" + guess + "?");
        print("UP Arrow: your number is higher, DOWN Arrow: your number is lower, ENTER: it is equal!");
    }

}
