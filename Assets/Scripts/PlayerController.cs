using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController character;
    [SerializeField] float playerSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] float backSpeed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        anim=GetComponentInChildren<Animator>();
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
            float moveSpeed = (vertical > 0) ? playerSpeed : backSpeed;
            character.SimpleMove(transform.forward * vertical * moveSpeed);
        }
    }
}
