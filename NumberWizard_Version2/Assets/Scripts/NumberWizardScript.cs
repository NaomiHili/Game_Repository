using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NumberWizardScript : MonoBehaviour {

    public Text myGuess;
    System.Random r = new System.Random();

    //Global Veriables.
    int min = 1;
    int max = 1000;
    int guess;
    int maxGuess = 5;


    // Use this for initialization
    void Start () {

        
        StartGame();

    }
	
	// Update is called once per frame
	void Update () {

      
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess + 1;
            NextGuess();

            maxGuess--;
            print(maxGuess);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            NextGuess();

            maxGuess--;
            print(maxGuess);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
        }

        if (maxGuess == 0)
        {
            SceneManager.LoadScene("Win");
        }
	}

    void StartGame()
    {
        min = 1;
        max = 1000;

        NextGuess();
    }

    void NextGuess()
    {

        guess = Random.Range(min, max + 1); 
        myGuess.text = guess + "?";

    }
    public void GuessHigher()
    {
        min = guess + 1;
        NextGuess();

        maxGuess--;
        print(maxGuess);
    }

    public void GuessLower()
    {
        max = guess - 1;
        NextGuess();
        maxGuess--;
        print(maxGuess);
    }

    public void CorrectAns()
    {
      
    }

    public void playAgain()
    {
        SceneManager.LoadScene("Start");
    }

    public void quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
