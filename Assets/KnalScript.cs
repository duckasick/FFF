using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnalScript : MonoBehaviour
{
    public GunScript gunScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gunScript.Kill();
        }
    }
}
