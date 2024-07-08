using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Linq; //нужно для параметра Distinct и для ToList

public class resolutionSettings : MonoBehaviour
{
    public  TMP_Dropdown resolutionDropdown;
    public static TMP_Dropdown resolutionValue;
    Resolution [] res;
    public Toggle screenToggle;

    void Start()
    {
        
        //Screen.fullScreen = true; // игра в фулскрине при запуске
        screenMode();
        screenToggle.isOn = !Screen.fullScreen;
        res = Screen.resolutions; // Получение массива доступных разрешений экрана
        //Resolution [] res = resolution.Distinct().ToArray(); //убирание дубликатов разрешения экрана с одинаковой герцовкой (у меня их нет, но может пригодиться)(не работает на герцорвку)
        //string [] stringResolution = new string[resolution.Length]; //создание массива строк длинной в кол-во resolution, чтобы передать в AddOptions
        List<string> resolution = new List<string> ();
        for (int i = 0; i < res.Length; i++)
        {
            //stringResolution[i] = resolution[i].ToString(); // заполнение массива разрешениями экрана с герцовкой
            //stringResolution[i] = resolution[i].width.ToString() + "x" + resolution[i].height.ToString(); // заполнение массива разрешениями экрана без герцовки
            if (res[i].refreshRateRatio.value == 60 && res[i].height % 9 == 0)
            resolution.Add(res[i].width.ToString() + "x" + res[i].height.ToString());
        }
        /*if (resolution.refreshRateRatio.value != 60)
        {
            resolution.Remove();
        }*/
        resolutionDropdown.ClearOptions(); //очищение опций дропдауна
        resolutionDropdown.AddOptions(resolution); //создание списка разрешений в дропдауне
        //Screen.SetResolution(resolution[resolution.Length - 1].width, resolution[resolution.Length - 1].height, true); // установка максимально доступного разрешения при запуске игры
    }
    /*public void SetRes()
    {
        Screen.SetResolution(resolution[resolutionDropdown.value].width, resolution[resolutionDropdown.value].height, Screen.fullScreen);
    }*/
    public void screenMode()
    {
        Screen.fullScreen = !screenToggle.isOn;
    }
    public void saveButtonClick()
    {
        string[] resolution = resolutionDropdown.options[resolutionDropdown.value].text.Split('x'); //разбиение строки на значения до знака и после
        int width = Convert.ToInt32(resolution[0]); // конвертирование строкового значения в инт и присвоение к переменной
        int height = Convert.ToInt32(resolution[1]);
        Screen.SetResolution(width, height, Screen.fullScreen); // применение разрешения экрана по разбитым значениям из строки
        resolutionValue.value = resolutionDropdown.value;        
        /*PlayerPrefs.SetInt("resolutionNumber", resolutionDropdown.value);
        PlayerPrefs.SetInt("screenToggle isOn", screenToggle.isOn? 1: 0);
        PlayerPrefs.SetInt ("fullScreen?", Screen.fullScreen? 1: 0);
        PlayerPrefs.Save();*/
    }
    public void goToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}

