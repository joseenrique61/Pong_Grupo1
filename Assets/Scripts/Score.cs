using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private TextMeshProUGUI textScore;
    private int points;
    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        textScore.SetText("0");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int pointsEntry)
    {
        points = pointsEntry;
        textScore.text = points.ToString();
    }
}
