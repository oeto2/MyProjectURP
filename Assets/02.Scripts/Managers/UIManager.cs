using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : SingletoneBase<UIManager>
{
    //UI ����
    public void OpenUI(GameObject gameObj)
    {
        gameObj.SetActive(true);
    }
}
