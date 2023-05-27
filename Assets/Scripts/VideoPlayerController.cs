using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public string finSceneName = "Fin"; 

    private VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(finSceneName);
    }
}