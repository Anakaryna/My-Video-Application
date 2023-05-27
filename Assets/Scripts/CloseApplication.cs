using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CloseApplication : MonoBehaviour
{
    public Button closeButton;

    private void Start()
    {
        closeButton.onClick.AddListener(LoadAccueilScene);
    }

    private void LoadAccueilScene()
    {
        SceneManager.LoadScene("Acceuil");
    }
}