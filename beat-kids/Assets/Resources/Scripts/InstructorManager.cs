using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructorManager : MonoBehaviour
{
    public void CallMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
