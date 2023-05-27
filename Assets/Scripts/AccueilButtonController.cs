using UnityEngine;
using UnityEngine.SceneManagement;

public class AccueilButtonController : MonoBehaviour
{
    public void GoToAccueilScene()
    {
        SceneManager.LoadScene("Acceuil"); // Charge la scène "Accueil"
    }
}