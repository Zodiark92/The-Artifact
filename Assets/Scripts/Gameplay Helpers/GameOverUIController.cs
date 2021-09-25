using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverUIController : MonoBehaviour
{
    public static GameOverUIController instance;

    [SerializeField]
    private Canvas gameOverCanvas;

    [SerializeField]
    private Text gameOverText;

    GameObject spawner;

    private void Awake()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemiesSpawner");

        if (instance == null)
        {
            instance = this;

        }



    }


    public  void GameOver(string GameOverInfo)
    {
        gameOverText.text = GameOverInfo;
        gameOverCanvas.enabled = true;

        Destroy(spawner);



    }
    public void RestartGame()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
        



    




}
