using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public void TrocaDeCena(string nomeDaCena)
    {
        
         SceneManager.LoadScene(nomeDaCena);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void MostrarPopUp (GameObject popup)
    {
        popup.SetActive(true);
    }

    public void DesligarPopUp (GameObject popup)
    {
        popup.SetActive(false);
    }

    public void DesativarBotao (Button botao)
    {
        botao.interactable = false;
    }
    public void AtivarBotao (Button botao)
    {
        botao.interactable = true;
    }


}