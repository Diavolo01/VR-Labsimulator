using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ReplayController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button replayButton;

    void Start()
    {
        // Ensure the button is set up correctly
        replayButton.onClick.AddListener(ReplayVideo);
    }

    void ReplayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
            videoPlayer.Play();
        }
    }
}
