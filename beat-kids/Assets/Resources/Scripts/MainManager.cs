using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Image m_MainLogo = null;
    public Button m_StartButton = null;
    public Button m_InstructorButton = null;

    public void CallSelectModeScene()
    {
        SceneManager.LoadScene("SelectMode");
    }

    public void CallInstructorScene()
    {
        SceneManager.LoadScene("Instructor");
    }
}
