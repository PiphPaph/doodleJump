using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuStartGameButton : MonoBehaviour
{
    public void startGameButtonClick() 
    {
        SceneManager.LoadScene("mainGame");
    }
}
