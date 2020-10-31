using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public Camera playerCamera;

    public GameObject gameOverText;
    public GameObject victoryText;
    public GameObject playerControllerButtons;

    private bool isGameOver, isVictory;
    void Update()
    {
        if (!isGameOver && player.transform.position.y < -5)
        {
            ShowGameOver();
        }
    }

    private void ShowGameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(!isVictory);
        playerControllerButtons.SetActive(false);
        playerCamera.transform.parent = null;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Main");
    }

    public void ShowVictory()
    {
        isVictory = true;
        victoryText.SetActive(true);
        playerControllerButtons.SetActive(false);
    }
}
