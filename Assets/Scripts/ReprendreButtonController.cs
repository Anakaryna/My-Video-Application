using UnityEngine;
using UnityEngine.Video;

public class ReprendreButtonController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void ReprendreVideo()
    {
        videoPlayer.Play(); // Reprend la lecture de la vidéo
    }
}