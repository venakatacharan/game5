using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manage : MonoBehaviour
{
    Boolean LoseDisabled = false;
    public GameObject MainMenuButton;
    public GameObject WinDisplay;
    public void Lost()
    {
        if(!LoseDisabled)
        {
            LoseDisabled = true;
            FindObjectOfType<Score>().DisplayLostText();
            MainMenuButton.SetActive(true);
            Invoke("Restart", 3);
        }    
    }

    public void Won()
    {
        LoseDisabled = true;
        WinDisplay.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
