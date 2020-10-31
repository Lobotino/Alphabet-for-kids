using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphabetCounter : MonoBehaviour
{
    private int alphabetCount = 0;

    public Text textCounter;

    public void onCollected()
    {
        alphabetCount++;
        textCounter.text = "Собрано букв: " + alphabetCount;
    }
}
