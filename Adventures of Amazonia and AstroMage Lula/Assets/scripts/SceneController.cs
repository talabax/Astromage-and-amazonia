using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

 


    [SerializeField] LivesData livesData;
    int sceneindex;

    public int CurrentIndex()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
        return sceneindex;

    }



    private void Start()
    {
        sceneindex = SceneManager.GetActiveScene().buildIndex;
    }



    public void LoadScene(int number)
    {



    }


    public void StartGame()
    {
        livesData.startingLives = 5;
        livesData.currentLives = livesData.startingLives;

        livesData.currentHealth = 100;
        livesData.currentHealth = livesData.startingHealth;

        SceneManager.LoadScene(1);

    }

    public void RestartGame()
    {
        livesData.currentHealth = livesData.startingHealth;
        livesData.currentLives = livesData.currentLives--;
        SceneManager.LoadScene(sceneindex);

    }



    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);


    }

    public void LoadCredits(int number)
    {



    }

    public void LoadTutorial(int number)
    {



    }

    public void LoadNextScene()
    {

        SceneManager.LoadScene(sceneindex + 1);


    }

    public void RestartCurrentLevel()
    {
        livesData.currentHealth = livesData.startingHealth;
        livesData.currentLives = livesData.currentLives - 1;
        SceneManager.LoadScene(CurrentIndex());

    }

}
