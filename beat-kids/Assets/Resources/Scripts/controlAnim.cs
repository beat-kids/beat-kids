using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controlAnim : MonoBehaviour
{
    public GameObject mainPanel = null;

    public void GameOver()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SelectMusic");
    }

    public void ActiveMain()
    {
        if(mainPanel != null)
        {
            mainPanel.SetActive(true);
        }
    }
}
