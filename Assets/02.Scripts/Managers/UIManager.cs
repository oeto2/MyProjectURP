using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : SingletoneBase<UIManager>
{
    //UI ¿­±â
    public void OpenUI(GameObject gameObj)
    {
        gameObj.SetActive(true);
    }
}
