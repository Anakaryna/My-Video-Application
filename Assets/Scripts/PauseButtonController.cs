using UnityEngine;
using UnityEngine.UI;

public class PauseButtonController : MonoBehaviour
{
    public Button accueilButton; 
    public Button reprendreButton; 

    private bool buttonsVisible = false; // Indique si les boutons sont visibles ou non

    private void Start()
    {
        HideButtons(); // Masque les boutons au début de la scène
    }

    public void ToggleButtons()
    {
        buttonsVisible = !buttonsVisible; // Inverse l'état des boutons

        if (buttonsVisible)
        {
            ShowButtons(); // Affiche les boutons si l'état est vrai
        }
        else
        {
            HideButtons(); // Masque les boutons si l'état est faux
        }
    }

    private void ShowButtons()
    {
        accueilButton.gameObject.SetActive(true); // Affiche le bouton "Accueil"
        reprendreButton.gameObject.SetActive(true); // Affiche le bouton "Reprendre"
    }

    private void HideButtons()
    {
        accueilButton.gameObject.SetActive(false); // Masque le bouton "Accueil"
        reprendreButton.gameObject.SetActive(false); // Masque le bouton "Reprendre"
    }
}