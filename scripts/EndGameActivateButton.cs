using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameActivateButton : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject mainMenuButton;
    public GameObject applyNameButton;
    public GameObject playerName;

    void Start()
    {
        restartButton.SetActive(false);
        mainMenuButton.SetActive(false);
        applyNameButton.SetActive(false);
        playerName.SetActive(false);
    }
    void Update()
    {
        if (EndGameTiger.tiger.GetComponent<BoxCollider2D>() == false)
        {
            restartButton.SetActive(true);
            mainMenuButton.SetActive(true);
            applyNameButton.SetActive(true);
            playerName.SetActive(true);
        }
    }
}
