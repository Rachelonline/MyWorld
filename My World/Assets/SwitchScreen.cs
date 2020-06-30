using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScreen : MonoBehaviour
{
    public void ToTaskScreen()
    {
        SceneManager.LoadScene("TaskScreen");
    }

    public void ToWorldScreen()
    {
        SceneManager.LoadScene("WorldScreen");
    }

    public void ToHomeScreen()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
