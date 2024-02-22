using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_MainPanel : MonoBehaviour
{
    [field : Header("Buttons")]
    [SerializeField] private Button StartButton;
    [SerializeField] private Button OptionButton;
    [SerializeField] private Button ExitButton;

    [field : Header("Panels")]
    [SerializeField] private GameObject OptionPanel;

    private void Awake()
    {
        TitleButtonsSetting();
    }

    public void TitleButtonsSetting()
    {
        StartButton.onClick.AddListener(() => LoadingSceneController.SceneLoad("MainScene"));
        OptionButton.onClick.AddListener(() => UIManager.Instance.OpenUI(OptionPanel));
        ExitButton.onClick.AddListener(() => TitleSceneManager.Instance.EndGame());
    }
}
