using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent nav;
    bool follow;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        follow = true;
        pos = other.transform.position;
        var health = GetComponent<Health>();
        if (health != null)
        {
            health.Damage(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            nav.SetDestination(pos);

        }
    }
}
