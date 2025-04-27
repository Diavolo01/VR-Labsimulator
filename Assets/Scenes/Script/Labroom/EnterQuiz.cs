using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterQuiz : MonoBehaviour
{
   public void ToQuiz()
    {
        SceneManager.LoadScene("QuizRoom");
    }
}
