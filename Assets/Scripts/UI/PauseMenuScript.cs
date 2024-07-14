using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject BackToCampButton;
    public GameObject SettingsMenu;
    public GameObject ReturnWarning;
    public GameObject TutorialsMenu;

    private PersistentItemsScript PI;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        Scene CurrentScene = SceneManager.GetActiveScene();

        if (CurrentScene.name == "1_StartScene" || CurrentScene.name == "4_EndScene")
        {
            Destroy(this.gameObject);
        }

        if (CurrentScene.name == "2_CampScene")
        {
            BackToCampButton.SetActive(false);
        }
        if (CurrentScene.name == "Mock Up Yin" || CurrentScene.name == "Mock Up Yin 2" || CurrentScene.name == "Mock Up Yin 3")
            BackToCampButton.SetActive(true);
    }
    void Start()
    {
        PI = GameObject.FindGameObjectWithTag("PersistentItem").GetComponent<PersistentItemsScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Time.timeScale == 1)
            {
                PauseGame();
            }
            else
            {
                StartGame();
            }
        }
    }

    public void StartGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        PI.MenuOpen = false;
    }

    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
        PI.MenuOpen = true;
    }

    public void ExitGame()
    {
        PlayerPrefs.SetInt("RoundCounter", 1);
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void ToCampScene()
    {
        PauseMenu.SetActive(false);
        ReturnWarning.SetActive(true);
    }
    public void ToFightScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PI.MenuOpen = false;
    }

    public void ToMainMenu()
    {
        PlayerPrefs.SetInt("RoundCounter", 1);
        SceneManager.LoadScene("1_StartScene");
    }

    public void OpenSettingsMenu()
    {
        SettingsMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    public void ReturnWarningYes()
    {
        SceneManager.LoadScene("2_CampScene");
        PI.MenuOpen = false;
    }
    public void ReturnWarningNo()
    {
        ReturnWarning.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void OpenTutorials()
    {
        TutorialsMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
    public void CloseTutorials()
    {
        TutorialsMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }
}
