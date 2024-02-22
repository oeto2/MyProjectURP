using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_OptionPanel : UIBase
{
    [SerializeField] private TMP_Text TitleText;

    private void Awake()
    {
        TitleOptionButtonsSetting();
    }

    public void TitleOptionButtonsSetting()
    {
        CloseButton.onClick.AddListener(() => Close());
    }
}
