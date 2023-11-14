using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    public void OnButtonPress(string buttonValue)
    {
        switch (buttonValue)
        {
            case "Challenge 1":
                SceneManager.LoadScene("Challenge 1");
                break;
            case "Laboratory 1":
                SceneManager.LoadScene("Laboratory 1");
                break;
            case "Exit":
                Application.Quit();
                break;
            default:
                break;
        }
    }
}
