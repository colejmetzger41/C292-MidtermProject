using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    
    public void GotoMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void GotoGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
