using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerScore.playerScore = 0;
            GameOver.IsPlayerDead = false;
            Time.timeScale = 1;

            SceneManager.LoadScene("Scena_001");
        }
    }
}
