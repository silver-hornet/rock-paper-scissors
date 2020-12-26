using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] GameObject gameScreen;
    [SerializeField] GameObject selectYourThrowScreen;

    [Header("Throws")]
    [SerializeField] string[] aiChoices = new string[3];
    [SerializeField] Text aiThrow;
    [SerializeField] Text yourThrow;

    [Header("End Game")]
    [SerializeField] Text decision;
    [SerializeField] GameObject playAgain;
    
    public void PlayGame(string yourChoice)
    {
        selectYourThrowScreen.SetActive(false);
        gameScreen.SetActive(true);
        StartCoroutine(ThrowCountdown(yourChoice));
    }

    IEnumerator ThrowCountdown(string yourChoice)
    {
        yourThrow.text = "3";
        aiThrow.text = "3";
        yield return new WaitForSeconds(1);
        yourThrow.text = "2";
        aiThrow.text = "2";
        yield return new WaitForSeconds(1);
        yourThrow.text = "1";
        aiThrow.text = "1";
        yield return new WaitForSeconds(1);
        DecideWinner(yourChoice);
    }

    void DecideWinner(string yourChoice)
    {
        int aiRandomChoice = Random.Range(0, aiChoices.Length);
        aiThrow.text = aiChoices[aiRandomChoice].ToString();
        yourThrow.text = yourChoice;

        if (yourThrow.text == aiThrow.text)
        {
            decision.text = "It's a draw. Click to play again.";
        }

        if (yourThrow.text == "ROCK" && aiThrow.text == "PAPER")
        {
            decision.text = "You lose. Click to play again.";
        }
        else if (yourThrow.text == "ROCK" && aiThrow.text == "SCISSORS")
        {
            decision.text = "You win. Click to play again.";
        }

        if (yourThrow.text == "PAPER" && aiThrow.text == "ROCK")
        {
            decision.text = "You win. Click to play again.";
        }
        else if (yourThrow.text == "PAPER" && aiThrow.text == "SCISSORS")
        {
            decision.text = "You lose. Click to play again.";
        }

        if (yourThrow.text == "SCISSORS" && aiThrow.text == "ROCK")
        {
            decision.text = "You lose. Click to play again.";
        }
        else if (yourThrow.text == "SCISSORS" && aiThrow.text == "PAPER")
        {
            decision.text = "You win. Click to play again.";
        }

        playAgain.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
}