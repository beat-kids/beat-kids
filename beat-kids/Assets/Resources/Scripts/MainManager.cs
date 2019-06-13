using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Image mainLogo = null;
    public Button startButton = null;
    public Button InstructorButton = null;

    public void CallModeSelectScene()
    {
        SceneManager.LoadScene("ModeSelect");
    }
    public void CallEnglishModeScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void CallMathModeScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void CallInstructorScene()
    {
        SceneManager.LoadScene("Instructor");
    }
    public void CallMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
