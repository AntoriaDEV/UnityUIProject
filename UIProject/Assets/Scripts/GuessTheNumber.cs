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
        randomNumber = Random.Range(0, 10);
        header.text = $"Welcome to the game! Pick a number 1 through 9, you have {guessAmt} of guesses remaining.";
    }
    public void SubmitGuess()
    {
        
    }
}
