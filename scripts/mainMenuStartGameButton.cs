using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuStartGameButton : MonoBehaviour
{
    public void startGameButtonClick() 
    {
        SceneManager.LoadScene("mainGame");
        Score.score = 0;
    }
}
