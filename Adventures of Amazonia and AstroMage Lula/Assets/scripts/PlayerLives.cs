 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerLives : MonoBehaviour
{
    int playerLives;
    int currentPlayerLives;
    string livesText;
    bool gameStarted;

    [SerializeField] TMP_Text life;
    SceneController sceneController;
    [SerializeField] LivesData livesData;

    void Start()
    {
        sceneController = FindObjectOfType<SceneController>();

        playerLives = livesData.StartingtLives();
        currentPlayerLives = playerLives;
        life.text = "x" + livesData.currentLives.ToString();
        currentPlayerLives = livesData.currentLives;


    }

    void Update()
    {
        //livesText = "x" + livesData.currentLives.ToString();

    }


    public void LifeLost()
    {
       if (livesData.currentLives > 0)
       {

            livesData.RemoveLives();
            sceneController.RestartCurrentLevel();
       }
       else if(livesData.currentLives <= 0)
       {
            Debug.Log("you died");
           sceneController.ReturnMenu();

       }

    }

    void StartingFirstLevelLife()
    {
        if (sceneController.CurrentIndex() == 1)
        {
            playerLives = livesData.currentLives;


        }
        else
        {
            playerLives = livesData.currentLives;

        }

    }


    public void Lifegain()
    {
        currentPlayerLives = currentPlayerLives++;



    }

    public int LifeTotal()
    {

        return currentPlayerLives;

    }



   




    


}
