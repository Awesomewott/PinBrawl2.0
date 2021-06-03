using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreTxt;
    static Score instance;
    int score = 0;
    static public Score Instance { get => instance; }


    public void Awake()
    {
        instance = this;
    }

    public void SetScore()
    {
        score += 100;
        scoreTxt.text = score.ToString();
    }

    public void TakeScore()
    {
        score -= 100;
        scoreTxt.text = score.ToString();
    }

}
