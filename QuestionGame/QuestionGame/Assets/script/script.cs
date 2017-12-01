using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour {

    System.Random rand = new System.Random();
    public Text myText;
    public InputField userInput;
    int rand1;
    int rand2;

    // Use this for initialization
    void Start () {
        
        print("Welcome to the question game!");

        GenerateQuestion();

    }

    // Update is called once per frame
    void Update() {


    }

    public void CheckAnswer()
    {
        Debug.Log("You have clicked the button congrats! ");

        int userAnswer = int.Parse(userInput.text);
        int multAnswer = rand1 * rand2;

        if (userAnswer == multAnswer)
        {
            print("Correct Answer! ");
            GenerateQuestion();
        }
        else
        {
            print("Incorrect ");
        }

    }

    void GenerateQuestion()
    {
        userInput.text = "";

        rand1 = rand.Next(0, 11);
        rand2 = rand.Next(0, 11);

        myText.text = "What is " + rand1 + " x " + rand2 + " = ";
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
