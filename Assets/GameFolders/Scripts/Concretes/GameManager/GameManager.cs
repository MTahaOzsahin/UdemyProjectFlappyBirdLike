
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager Instance { get; private set; }

    public event System.Action<int> OnScoreChanged; 

    private void Awake()
    {
        SingletonThisGameobject();
    }

    private void SingletonThisGameobject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore()
    {

        score++;
        OnScoreChanged!.Invoke(score);   
        //OnScoreChanged(score); böylede yazýlabilir sanýrým
    }
    public void RestartGame()
    {
        score = 0;
        StartCoroutine(RestartGameAsync());
        Time.timeScale = 1f;
    }
    IEnumerator RestartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }
}
