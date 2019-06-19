using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeManager : MonoBehaviour
{
    public void CallMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnClickMode(string _mode)
    {
        PlayerPrefs.SetString("Mode", _mode);
        this.CallSelectMusicScene();
    }

    private void CallSelectMusicScene()
    {
        SceneManager.LoadScene("SelectMusic");
    }
}
