using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("Classroom"); another method
    }
    public void Tutorial()
    {
        Debug.Log("U click on tutorial");
        SceneManager.LoadScene("Tutorial");
    }
    public void MainMenuB()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GotoLab()
    {
        SceneManager.LoadScene("Labroom")
;    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("You are done");
    }
}
