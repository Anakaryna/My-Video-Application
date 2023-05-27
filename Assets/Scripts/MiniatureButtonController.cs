using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniatureButtonController : MonoBehaviour
{
    public string videoSceneName = "Video"; 

    public void LoadVideoScene()
    {
        SceneManager.LoadScene(videoSceneName); // Charge la scène vidéo
    }
}