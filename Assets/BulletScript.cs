using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerKillScript stuff = other.GetComponent<PlayerKillScript>();
            stuff.Kill();
            print("bullet");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        rb.useGravity = true;
    }
}
