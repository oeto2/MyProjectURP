using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : SingletoneBase<TitleSceneManager>
{
    private void Awake()
    {
        Init();

        //�Ŵ����� ������Ʈ�� ��������
        UIManager.Instance.Init();

        //������ ������Ʈ ��������
        Init_Prefabs();
    }

    private void Init_Prefabs()
    {
        ResourceManager.Instance.Instantiate("UI/Title/UICanvas");
    }

    ////Scene ��ȯ
    //public void ChangeScene(string scene)
    //{
    //    SceneManager.LoadScene(scene);
    //}

    //���� ����
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("���� ����");
    }
}
