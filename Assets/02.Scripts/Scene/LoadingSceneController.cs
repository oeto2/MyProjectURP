using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneController : MonoBehaviour
{
    [SerializeField] private Slider LoadingBar;
    public static string nextScene;

    public static void SceneLoad(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }

    private void Start()
    {
        StartCoroutine(LoadSceneProcess());
    }

    IEnumerator LoadSceneProcess()
    {
        //비동기 방식 로드
        AsyncOperation loadScene = SceneManager.LoadSceneAsync(nextScene);
        loadScene.allowSceneActivation = false;

        float timer = 0f;
        while(!loadScene.isDone)
        {
            yield return null;

            if(loadScene.progress < 0.9f)
            {
                LoadingBar.value = loadScene.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                LoadingBar.value = Mathf.Lerp(0.9f, 1f, timer);
                if (LoadingBar.value >= 1f)
                {
                    loadScene.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
