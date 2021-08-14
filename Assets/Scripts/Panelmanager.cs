using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panelmanager : MonoBehaviour
{
    [SerializeField] GameObject main;
    [SerializeField] GameObject volume;
    public void Main()
    {
        main.SetActive(true);
        volume.SetActive(false);
    }
    public void Volume()
    {
        main.SetActive(false);
        volume.SetActive(true);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
