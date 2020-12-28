using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class User02
{
    public string userName;
    public int userScore;

    public User02()
    {
        userScore = voice05.playerScore;
        userName = voice05.playerName;
    }
}
