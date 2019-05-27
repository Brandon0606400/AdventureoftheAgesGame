using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Lives : MonoBehaviour
{

    public Text LivesText;
    private int numericalLives = 3;



    // Use this for initialization
    void Start()
    {
        numericalLives = PlayerPrefs.GetInt("lives", 3);
        LivesText.text = numericalLives.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // This removes one life when the player dies
    public void LoseLife()
    {
        numericalLives = numericalLives - 1;
        LivesText.text = numericalLives.ToString();
    }

    // This saves the life count after losing one
    public void SaveLives()
    {
        PlayerPrefs.SetInt("lives", numericalLives);
    }

    // Displays the game over screen when on zero lifes
    public bool IsGameOver()
    {
        if (numericalLives <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}