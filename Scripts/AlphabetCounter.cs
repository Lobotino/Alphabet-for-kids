using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphabetCounter : MonoBehaviour
{
    public GameController gameController;

    public int victoryCount = 33;
    
    public int alphabetCount = 0;

    public Text textCounter;

    public void OnCollected()
    {
        alphabetCount++;
        textCounter.text = "Собрано букв: " + alphabetCount;

        if (alphabetCount >= victoryCount)
        {
            gameController.ShowVictory();
        }
    }
}
