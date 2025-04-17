using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitLine : MonoBehaviour
{
    [SerializeField] private GameObject status;
    [SerializeField] private GameObject retryButton;
    [SerializeField] BallMovement ball;
    [SerializeField] AIMove AI;
    [SerializeField] PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        Debug.Log(collision);
        status.SetActive(true);
        retryButton.SetActive(true);
    }
}
