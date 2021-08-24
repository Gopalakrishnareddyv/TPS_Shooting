using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningScript : MonoBehaviour
{
    [SerializeField] Transform helicopter;
    [SerializeField] Transform[] landingPoints;
    private void Start()
    {
        int point = Random.Range(0, landingPoints.Length);
        helicopter.transform.position = landingPoints[point].transform.position;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
