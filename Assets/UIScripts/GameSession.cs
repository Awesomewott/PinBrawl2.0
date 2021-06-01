using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;


public class GameSession : MonoBehaviour
{
    public float Score { get; set; } = 0;
    public int highScore { get; set; } = 0;
    public TextMeshProUGUI ScoreUI;
    public TextMeshProUGUI timerUI;
    public GameObject startScreen;

    float timer = 0;
  

    static GameSession instance = null;
    public static GameSession Instance
    {
        get { return instance; }
    }

    //float timer = 90.0f;
    public enum eState
    {
        StartSession,
        Session,
        EndSession,
        Gameover
    }

    public eState State { get; set; } = eState.StartSession;

    private void Awake()
    {
      instance = this;
    }

    private void Start()
    {
        EventManager.Instance.Subscribe("PlayerDead", OnPlayerDead);
       
    }
    private void Update()
    {
        switch(State)
        {
            case eState.StartSession:
                Score = 0;
                EventManager.Instance.TriggerEvent("StartSession");
                //startSessionEvent?.Invoke();
               // GameController.Instance.transition.StartTransition(Color.clear, 1);
                State = eState.Session;
                break;
            case eState.EndSession:
                timer -= Time.deltaTime;
                if(timer <= 0)
                {
                    GameObject gameObject = GameObject.FindGameObjectWithTag("PlayerDead");
                    Destroy(gameObject);
                    State = eState.StartSession;
                }
                break;
            case eState.Gameover:
                break;
            default:
                break;
                
        }
      
    }
    public void AddPoints(int points)
    {
        
        timer += Time.deltaTime;
        points = (int)timer;
        Score = points;
        ScoreUI.text = string.Format("{0:D4}", Score);
    }

    public void OnPlayerDead()
    {
      //  GameController.Instance.transition.StartTransition(Color.black, 1);
        timer = 2;
        State = eState.EndSession;
    }
}
