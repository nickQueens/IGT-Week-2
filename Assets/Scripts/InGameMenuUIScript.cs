using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuUIScript : MonoBehaviour
{
    public GameObject menuCanvas;
    public KeyCode pausekey = KeyCode.P;

    public void OnButtonPress(string buttonText)
    {
        switch (buttonText)
        {
            case "MainMenu":
                SceneManager.LoadScene("MenuScene");
                break;
            case "Back":
                menuCanvas.SetActive(false);
                break;
            default:
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pausekey))
        {
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}
