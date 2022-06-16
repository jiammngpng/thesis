using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    
    public void QuitGame()
    {
        Debug.Log("Exited Successfully");
        Application.Quit();
    }
}
