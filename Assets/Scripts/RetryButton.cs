using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject retryButton;
    [SerializeField] GameObject gameStatus;
    /*
    [SerializeField] BallMovement ball;
    [SerializeField] AIMove AI;
    [SerializeField] PlayerMovement player;*/
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RestartCurrentScene()
    {
        /*
        ball = new BallMovement();
        AI = new AIMove();
        player = new PlayerMovement();*/

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        gameStatus.SetActive(false);
        retryButton.SetActive(false);
    }
}
