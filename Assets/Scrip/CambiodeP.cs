using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeP : MonoBehaviour
{
   public void Jugar()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
