using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // References
    [SerializeField] GameObject gameScreen;
    [SerializeField] GameObject selectYourThrowScreen;
    [SerializeField] Text yourThrow;
    [SerializeField] Text aiThrow;

    // Config
    [SerializeField] string[] aiChoices = new string[3];

    public void PlayGame(string yourChoice)
    {
        selectYourThrowScreen.SetActive(false);
        gameScreen.SetActive(true);
        StartCoroutine(ThrowCountdown(yourChoice));
    }

    IEnumerator ThrowCountdown(string yourChoice)
    {
        int aiRandomChoice = Random.Range(0, aiChoices.Length);
        yourThrow.text = "3";
        aiThrow.text = "3";
        yield return new WaitForSeconds(1);
        yourThrow.text = "2";
        aiThrow.text = "2";
        yield return new WaitForSeconds(1);
        yourThrow.text = "1";
        aiThrow.text = "1";
        yield return new WaitForSeconds(1);
        yourThrow.text = yourChoice;
        aiThrow.text = aiChoices[aiRandomChoice].ToString();
        DecideWinner();
    }

    void DecideWinner()
    {
        if (yourThrow.text == aiThrow.text)
        {
            Debug.Log("Draw");
        }

        if (yourThrow.text == "Rock" && aiThrow.text == "Paper")
        {
            Debug.Log("You lose");
        }

        if (yourThrow.text == "Rock" && aiThrow.text == "Scissors")
        {
            Debug.Log("You win");
        }

        if (yourThrow.text == "Paper" && aiThrow.text == "Rock")
        {
            Debug.Log("You win");
        }

        if (yourThrow.text == "Paper" && aiThrow.text == "Scissors")
        {
            Debug.Log("You lose");
        }

        if (yourThrow.text == "Scissors" && aiThrow.text == "Rock")
        {
            Debug.Log("You lose");
        }

        if (yourThrow.text == "Scissors" && aiThrow.text == "Paper")
        {
            Debug.Log("You win");
        }
    }
}