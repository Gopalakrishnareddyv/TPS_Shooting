using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour
{
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    public void Update()
    {
        scoreText.text = "Score : " + Score.instance.lastScore;
    }
       
    
}
