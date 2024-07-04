using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour
{
    public void ExitToMainMenuButtonClick()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
