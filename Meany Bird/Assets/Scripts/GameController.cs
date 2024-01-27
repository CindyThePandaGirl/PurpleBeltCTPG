using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game over canvas is used for the game
    [Header("Game Over UI pbject for displaying game over screen")]
    public GameObject gameOverCanvas;
    //Score Canvas that is used for the game
    [Header("Score Ui object for displaying Score")]
    public GameObject scoreCanvas;
    //Spawner object that is used for the game
    [Header("Spawner object for spawning objects in the game")]
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        //Speed for the game is at a  playing state 
        Time.timeScale = 1;
        //Score in visible
        scoreCanvas.SetActive(true);
        //Game over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is shown in the game
        spawner.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        //Game over UI is visible
        gameOverCanvas.SetActive(true);
        //The spawner is now invisible in the game
        spawner.SetActive(false);
        //The speed for the game is now at a stopping state
        Time.timeScale = 0;
    }
}
