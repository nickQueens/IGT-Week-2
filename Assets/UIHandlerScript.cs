using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandlerScript : MonoBehaviour
{
    public void OnButtonPress(string buttonValue)
    {
        Debug.Log("Button Press");
        switch(buttonValue)
        {
            case "Lab":
                SceneManager.LoadScene("Lab");
                Debug.Log("Lab pressed");
                break;
            case "Challenge":
                SceneManager.LoadScene("Challenge");
                Debug.Log("Challenge pressed");
                break;
            case "Exit":
                Application.Quit();
                Debug.Log("Exit pressed");
                break;
            default:
                Debug.Log("Default case");
                break;
        }
    }
}
