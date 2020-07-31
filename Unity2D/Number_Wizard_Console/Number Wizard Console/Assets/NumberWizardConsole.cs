using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardConsole : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wozard");  //Debug.Log gives more control than print
        Debug.Log("Pick up a number, but don't tell me what it is...");
        Debug.Log("Highest Number you can pick is: " + max);
        Debug.Log("Lowest Number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up = higher, Push down = lower, Push enter = correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than... " + guess);
    }
}
