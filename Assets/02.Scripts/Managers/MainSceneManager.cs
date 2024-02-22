using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    private void Awake()
    {
        //������ ����� �Ŵ����� ����
        GameManager.Instance.Init();
        ResourceManager.Instance.Init();

        ResourceManager.Instance.Instantiate("Maps/Dungeon_Map");
        ResourceManager.Instance.Instantiate("Maps/Reflection_Probes");
        ResourceManager.Instance.Instantiate("Volumes/Global Volume");
    }
}
