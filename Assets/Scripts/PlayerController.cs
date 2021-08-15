using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController character;
    [SerializeField] float playerSpeed;
    [SerializeField] float rotateSpeed;
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
        var horizotal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var movement = new Vector3(horizotal, 0, vertical);
        character.SimpleMove(movement * Time.deltaTime * playerSpeed);
        anim.SetFloat("Speed", movement.magnitude);
        Quaternion direction = Quaternion.LookRotation(movement);
        transform.rotation = Quaternion.Slerp(transform.rotation, direction, Time.deltaTime * rotateSpeed) ;
    }
}
