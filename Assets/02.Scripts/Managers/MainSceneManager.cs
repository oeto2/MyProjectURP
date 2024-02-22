using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    private void Awake()
    {
        //씬에서 사용할 매니저들 생성
        GameManager.Instance.Init();
        ResourceManager.Instance.Init();

        ResourceManager.Instance.Instantiate("Maps/Dungeon_Map");
        ResourceManager.Instance.Instantiate("Maps/Reflection_Probes");
        ResourceManager.Instance.Instantiate("Volumes/Global Volume");
    }
}
