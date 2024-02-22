using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : SingletoneBase<TitleSceneManager>
{
    private void Awake()
    {
        Init();

        //매니저급 오브젝트들 동적생성
        UIManager.Instance.Init();

        //프리팹 오브젝트 동적생성
        Init_Prefabs();
    }

    private void Init_Prefabs()
    {
        ResourceManager.Instance.Instantiate("UI/Title/UICanvas");
    }

    ////Scene 전환
    //public void ChangeScene(string scene)
    //{
    //    SceneManager.LoadScene(scene);
    //}

    //게임 종료
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("게임 종료");
    }
}
