using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeDoLeveldeJogo;
   public void Jogar()
   {
        SceneManager.LoadScene(nomeDoLeveldeJogo);
   }
}
