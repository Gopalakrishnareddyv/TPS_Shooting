using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    float fireRate = 1f;
    int damage = 1;
    float timer = 0;
    [SerializeField] Transform firePoint;
    [SerializeField] ParticleSystem particle;
    AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > fireRate)
        {
            if (Input.GetMouseButton(0))
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                particle.Play();
                timer = 0;
                FireGun();
            }
            
        }
    }

    private void FireGun()
    {
        Debug.DrawRay(Camera.main.transform.position,Camera.main.transform.forward*50, Color.blue ,2f);
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, 100))
        {
            var health = hit.collider.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.Damage(1);
            }
        }
    }
}
