using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBase : MonoBehaviour
{
    [SerializeField] protected Button CloseButton;

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
