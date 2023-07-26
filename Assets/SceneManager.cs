// Generated By Chat GPT 4.0  

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject loadingScreen; // Reference to the loading screen UI element

    public void LoadSceneByName(string sceneName)
    {
        // Show the loading screen before loading the new scene
        loadingScreen.SetActive(true);

        // Load the new scene asynchronously by name
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void LoadSceneByIndex(int sceneIndex)
    {
        // Show the loading screen before loading the new scene
        loadingScreen.SetActive(true);

        // Load the new scene asynchronously by index
        SceneManager.LoadSceneAsync(sceneIndex);
    }

    // You can use this function to load the scene asynchronously with a loading bar or progress indicator
    public void LoadSceneWithProgressBar(string sceneName)
    {
        StartCoroutine(LoadSceneWithProgressBarCoroutine(sceneName));
    }

    private IEnumerator LoadSceneWithProgressBarCoroutine(string sceneName)
    {
        // Show the loading screen before loading the new scene
        loadingScreen.SetActive(true);

        // Load the new scene asynchronously by name
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the scene is fully loaded (progress reaches 0.9)
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress / 0.9f);

            // You can update your loading screen or progress bar with the 'progress' value
            // For example, you could change the scale of a loading bar or update a progress text
            // progressBar.localScale = new Vector3(progress, progressBar.localScale.y, progressBar.localScale.z);
            // progressText.text = (progress * 100f).ToString("F0") + "%";

            yield return null;
        }
    }
}
