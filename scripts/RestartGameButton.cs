using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGameButton : MonoBehaviour
{
    public bool clicked = false;

    public void RestartGameButtonClick()
    {
        SceneManager.LoadScene("mainGame");
        Score.score = 0;
    }
    public void isButtonClicked()
    {
        clicked = true;

    }
    void Update() 
    {
        if (clicked)
        {
            RestartGameButtonClick();
            clicked = false;
            
        }
    }
}
