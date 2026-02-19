using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int randomNumber = 0;
    int userInput = 0;
    int guessAmt = 3;
    [SerializeField] TMP_Text header;
    [SerializeField] Button submit;
    [SerializeField] Button reset;
    [SerializeField] TMP_InputField input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameSetup();
        
        //Set the buttons to call a function
        Button redo = reset.GetComponent<Button>();
        redo.onClick.AddListener(GameSetup);
        Button check = submit.GetComponent<Button>();
        check.onClick.AddListener(SubmitGuess);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameSetup()
    {
        //resets game back to original state.
        submit.interactable = true;
        randomNumber = Random.Range(1, 10);
        guessAmt = 3;
        header.text = $"Welcome to the game! Pick a number 1 through 9, you have {guessAmt} of guesses remaining.";
        
    }
    public void SubmitGuess()
    {
        //make sure that input is a number, call the user stupid if its not.
        if (!int.TryParse(input.text, out userInput))
        {
            header.text = "Please enter a valid number.";
            return;
        }
        else
        {
            int userInput = int.Parse(input.text);
            guessAmt--;

            //go through if statements to check if its the number or not, or if you are out fo guesses.
            if (userInput == randomNumber)
            {
                header.text = "Congrats! You got it!";
                submit.interactable = false;
            }
            else if (guessAmt <= 0)
            {
                header.text = "Game over! No guesses left.";
                submit.interactable = false;
            }
            else
            {
                header.text = $"Wrong guess. {guessAmt} tries left.";
            }
        }
    }
}
