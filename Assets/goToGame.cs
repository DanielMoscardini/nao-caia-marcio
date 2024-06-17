using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToGame : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        Debug.Log("ChangeScene chamado com: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
