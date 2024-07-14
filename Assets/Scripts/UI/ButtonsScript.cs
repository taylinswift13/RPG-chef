using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject SettingsMenu;
    public GameObject MainMenu;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("RoundCounter", 1);
        SceneManager.LoadScene("2_CampScene");
    }

    public void ToStartMenu()
    {
        SceneManager.LoadScene("1_StartScene");
    }

    public void ToCredits()
    {
        SceneManager.LoadScene("4_EndScene");
    }

    public void OpenSettings()
    {
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
}
