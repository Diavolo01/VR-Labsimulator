using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timerUI : MonoBehaviour
{
    public float displayTime = 5f; 
    public GameObject nextPanel; 

    private void OnEnable()
    {
        StartCoroutine(CloseAndOpenPanelAfterTime());
    }

    private IEnumerator CloseAndOpenPanelAfterTime()
    {
        yield return new WaitForSeconds(displayTime);

        gameObject.SetActive(false);

        if (nextPanel != null)
        {
            nextPanel.SetActive(true);
        }
    }
}
