using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitAndLoad(2f));
        }
    }


    private IEnumerator WaitAndLoad(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        LoadNextScene();
    }   

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
