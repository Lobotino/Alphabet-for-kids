using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public Camera playerCamera;

    public GameObject gameOverText;
    public GameObject playerControllerButtons;

    private bool isGameOver;
    void Update()
    {
        if (!isGameOver && player.transform.position.y < -5)
        {
            ShowGameOver(true);
        }
    }

    private void ShowGameOver(bool gameOver)
    {
        isGameOver = gameOver;
        gameOverText.SetActive(gameOver);
        playerControllerButtons.SetActive(!gameOver);
        playerCamera.transform.parent = null;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Main");
    }
}
