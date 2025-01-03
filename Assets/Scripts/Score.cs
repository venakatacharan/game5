using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform PlayerTransform;
    public Transform GroundTransform;
    public Text ScoreText;
    Boolean HasLost = false;
    string finalScore = "";
    float initial;
    // Start is called before the first frame update
    void Start()
    {
        initial = PlayerTransform.position.z;
        
    }
    
    public void DisplayLostText()
    {
        HasLost = true;
        finalScore = ScoreText.text;
    }
    // Update is called once per frame
    void Update()
    {
        if (HasLost)
        {
            
            ScoreText.text = "Game over. score is" + finalScore;
        }
        else {
            ScoreText.text = (PlayerTransform.position.z - initial).ToString("0");
        }
        
    }
}
