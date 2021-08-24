using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    // Start is called before the first frame update
    public void Update()
    {
        scoreText.text = "Score : " + Score.instance.lastScore;
        highScoreText.text = "HighSCore : " + Score.instance.highScore;
    }
}
