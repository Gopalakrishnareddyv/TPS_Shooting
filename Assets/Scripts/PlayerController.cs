using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    CharacterController character;
    [SerializeField] float playerSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] float jumpSpeed;
    Animator anim;
    Helicopter helicopter;
    // Start is called before the first frame update
    void Start()
    {
        helicopter = GameObject.Find("Plane").GetComponent<Helicopter>();
        character = GetComponent<CharacterController>();
        anim=GetComponentInChildren<Animator>();
        helicopter.Landing();
    }

    // Update is called once per frame
    void Update()
    {
        Score.instance.Increment();
        var horizotal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizotal, 0, vertical);
        anim.SetFloat("Speed", vertical);
        transform.Rotate(Vector3.up, horizotal * rotateSpeed * Time.deltaTime);
        if (vertical != 0)
        {
            
            character.SimpleMove(transform.forward * vertical * playerSpeed);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
