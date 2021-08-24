using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    //[SerializeField] Transform fan;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Landing()
    {
        rb.isKinematic = false;
    }
    private void Update()
    {
        //fan.transform.Rotate(0, 360, 0);
    }
}
