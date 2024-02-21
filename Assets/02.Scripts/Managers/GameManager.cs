using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletoneBase<GameManager>
{
    //Game Events
    public event Action OnGameStart;
    public event Action OnGameEnd;
}
