using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLab : MonoBehaviour
{
    // The Play method is probably called from a UI button or another interaction.
    public void Ready()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Labroom"); 
    }
}