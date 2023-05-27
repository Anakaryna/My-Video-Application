using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    VideoPlayer videoPlayer;
    public Button pauseButton; // Assign this in the inspector

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        pauseButton.onClick.AddListener(TogglePause);
    }

    void TogglePause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        
    }
}