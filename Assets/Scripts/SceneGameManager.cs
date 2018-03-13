using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGameManager : MonoBehaviour {

    public void openGame()
    {
        SceneManager.LoadScene("Brickix");
        Time.timeScale = 1;
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
