using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using GoogleMobileAds.Api;




public class ViewController : MonoBehaviour
{
    [Header("Menu - set in Inspector")]
    //[SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject mainMenuUI;
    //[SerializeField] GameObject pausedUI;
    //[SerializeField] GameObject inGameUI;
    [SerializeField] GameObject settingsMenuUI;
    [SerializeField] GameObject levelsMenuUI;
    //[SerializeField] GameObject table;
    //[SerializeField] GameObject inputPanel;
    //AddInterstitial interAD;
    public bool isGamePlayed { get; private set; }
    public bool paused;

    
    #region MenuUI


    private void Start()
    {
        //interAD = mainMenuUI.GetComponent<AddInterstitial>();
       
        ShowMainMenu();
    }
    void ShowUI(GameObject newUI) //деактивирует все окна кроме полученного
    {
        GameObject[] allUI = { mainMenuUI, settingsMenuUI, levelsMenuUI };
        foreach (GameObject uiToHide in allUI)
        {
            uiToHide.SetActive(false);
        }

        newUI.SetActive(true);
    }
    public void ShowMainMenu() 
    {
        //table.SetActive(false);
        ShowUI(mainMenuUI);
        isGamePlayed = false;
        //GameManager.instance.UpdateText();
       
    }
    public void ShowSettingsMenu() 
    {
        ShowUI(settingsMenuUI);
        isGamePlayed = false;
    }
    public void ShowLevelsMenu() 
    {
        ShowUI(levelsMenuUI);
        isGamePlayed = false;
    }
    public void StartGame() 
    {
        //ShowUI(inGameUI);
        isGamePlayed = true;
        //GameManager.instance.inGame = true;
        SceneManager.LoadScene(1);
        //inputPanel.SetActive(true);
        
    }
    /*public void GameOver()
    {
        ShowUI(gameOverUI);
        isGamePlayed = false;
        GameManager.instance.inGame = false;
        inputPanel.SetActive(false);
        
        
    }*/
    /*public void SetPaused(bool paused) 
    {
        inGameUI.SetActive(!paused);
        pausedUI.SetActive(paused);
        if (paused)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }*/
    #endregion
}
