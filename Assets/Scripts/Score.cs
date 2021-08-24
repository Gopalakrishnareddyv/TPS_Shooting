using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    float score;
    [SerializeField]Text scoreText;
    public  float lastScore;
    public float highScore=0;
    public static Score instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void Increment()
    {
        score +=Time.deltaTime;
        if (score >= 150)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        scoreText.text = "Score : " +Mathf.Round( score);
        lastScore =Mathf.Round( score);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (highScore >= lastScore)
        {
            highScore = lastScore;
        }
    }
}
