using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void MainMenu()
    {
        Debug.Log("Main menu clicked");
        SceneManager.LoadScene("Welcome");

    }
}
