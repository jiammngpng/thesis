using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject loadingPanel;
    [SerializeField] private Slider progressBar;
    
    public void Awake()
    {
        loadingPanel.SetActive(false);
    }

    public void LoadLevel(string levelName)
    {
        loadingPanel.SetActive(true);
        StartCoroutine(LoadLevelAsync(levelName));
    }

    private IEnumerator LoadLevelAsync(string levelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress);
            progressBar.value = progress;

            Debug.Log(progress);
            yield return null;
        }
    }
    
    public void QuitGame()
    {
        Debug.Log("Exited Successfully");
        Application.Quit();
    }
}
