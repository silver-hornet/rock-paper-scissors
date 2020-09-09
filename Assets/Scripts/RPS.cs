using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPS : MonoBehaviour
{
    [SerializeField] string[] AI = new string[3];

    void Start()
    {
        Debug.Log("Time to play (1)Rock, (2)Paper, (3)Scissors! Choose your option.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            int randomAI = Random.Range(0, AI.Length);

            Debug.Log("You have chosen (1)Rock. Good luck!");
            Debug.Log("Computer chooses... " + AI[randomAI]);

            switch(randomAI)
            {
                case 0: //
                    Debug.Log("It's a draw!");
                    break;
                case 1: //
                    Debug.Log("AI wins! " + AI[randomAI] + " beats Rock");
                    break;
                case 2: //
                    Debug.Log("You win! " + "Rock beats " + AI[randomAI]);
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            int randomAI = Random.Range(0, AI.Length);

            Debug.Log("You have chosen (2)Paper. Good luck!");
            Debug.Log("Computer chooses... " + AI[randomAI]);

            switch (randomAI)
            {
                case 0: //
                    Debug.Log("You win! " + "Paper beats " + AI[randomAI]);
                    break;
                case 1: //
                    Debug.Log("It's a draw!");
                    break;
                case 2: //
                    Debug.Log("AI wins! " + AI[randomAI] + " beats Paper");
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            int randomAI = Random.Range(0, AI.Length);

            Debug.Log("You have chosen (3)Scissors. Good luck!");
            Debug.Log("Computer chooses... " + AI[randomAI]);

            switch (randomAI)
            {
                case 0: //
                    Debug.Log("AI wins! " + AI[randomAI] + " beats Scissors"); 
                    break;
                case 1: //
                    Debug.Log("You win! " + "Scissors beats " + AI[randomAI]);
                    break;
                case 2: //
                    Debug.Log("It's a draw!");
                    break;
            }
        }
    }
}
