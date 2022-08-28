using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject storyPanel, settingsPanel, creditsPanel;

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void openStory()
    {
        storyPanel.SetActive(true);
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
    
    public void openSettings()
    {
        storyPanel.SetActive(false);
        settingsPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }
    
    public void openCredits()
    {
        storyPanel.SetActive(false);
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
}
