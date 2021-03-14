using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuNavScript : MonoBehaviour
{
    //public 
    public TextMeshProUGUI PlayText;
    public TextMeshProUGUI RulesText;
   // public TextMeshProUGUI BackstoryText;
    public TextMeshProUGUI ExitText;

    public int Index = 0;
    private Array[] arr;

    
    public Color newColor;
    public Color nonSelected;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Out of bounds check
        if(Index < 0)
        {
            Index = 0;
        }

        if(Index > 2)
        {
            Index = 2;
        }

        if (Index == 0)
        {
            // Set this to active
            PlayText.color = newColor;

            // Set these to inactive
            RulesText.color = nonSelected;
            //BackstoryText.color = nonSelected;
            ExitText.color = nonSelected;

          if(Input.GetKeyDown(KeyCode.Return))
            {
                // Loads the actual game.
               SceneManager.LoadScene("GameScreen", LoadSceneMode.Single);
            }


        }

        if(Index == 1)
        {
            // Set this to active
            RulesText.color = newColor;

            // Set these to inactive
            PlayText.color = nonSelected;
            //BackstoryText.color = nonSelected;
            ExitText.color = nonSelected;


            if (Input.GetKeyDown(KeyCode.Return))
            {
                // Loads the rules segment of the main menu, telling the player how to play.
                SceneManager.LoadScene("Controls", LoadSceneMode.Single);
            }


        }

        if (Index == 2)
        {
            // Set this to active
            ExitText.color = newColor;

            // Set these to inactive
            PlayText.color = nonSelected;
            RulesText.color = nonSelected;
            //BackstoryText.color = nonSelected;

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Application.Quit();
                // Closes the game, only works on the final build, not able to test in this version of unity.

            }
        }
        
    
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Allows the menu to scroll down using arrow keys.
            Index -= 1;
        }

     
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Allows the menu to scroll up using arrow keys.
            Index += 1;
        }

    }
}
