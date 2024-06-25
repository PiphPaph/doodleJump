using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuSettingsButton : MonoBehaviour
{
    public void openSettingsButtonClick()
    {
        SceneManager.LoadScene("Settings");
    }
}
