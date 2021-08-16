using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float score = 0;
    [SerializeField]Text scoreText;
    public  float lastScore;
    public static Score instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void Increment()
    {
        score +=Time.deltaTime;
        scoreText.text = "Score : " +Mathf.Round( score);
        lastScore =Mathf.Round( score);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
