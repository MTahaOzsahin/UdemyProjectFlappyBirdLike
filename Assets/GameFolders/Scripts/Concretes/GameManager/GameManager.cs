

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
    public void StartGame()
    {
        score = 0;
        StartCoroutine(StartGameAsync());
        Time.timeScale = 1f;
    }
    IEnumerator StartGameAsync()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void ReturnMenu()
    {
        StartCoroutine(ReturnMenuAsync());
    }

    public IEnumerator ReturnMenuAsync()
    {
        yield return SceneManager.LoadSceneAsync("Menu");
    }
}
