using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScoreBoardButton : MonoBehaviour
{   
    public void openScoreBoardButtonClick() 
    {
       SceneManager.LoadScene("ScoreBoard");
    }
   
}
