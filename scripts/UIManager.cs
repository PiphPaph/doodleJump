using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public InputField playerNameInput;
    public ScoreboardManager scoreboardManager;

    public void OnSubmitName() 
    {
        string playerName = playerNameInput.text;
        int playerScore = Score.score;

        scoreboardManager.AddNewScoreEntry(playerName, playerScore);
    }
}
