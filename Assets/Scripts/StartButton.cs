﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This allows us to use the scene loading function
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    // This will be called by the button component
    // when the button is clicked

    // When the game starts it refreshes the games lives and score
    public void StartGame()
    {
        // Reset score
        PlayerPrefs.DeleteKey("score");

        // Reset lives
        PlayerPrefs.DeleteKey("lives");

        // Load the first level
        SceneManager.LoadScene("TutLevel");
    }

}