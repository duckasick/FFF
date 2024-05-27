using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    public GameObject target;
    public ParticleSystem blood;
    // Start is called before the first frame update
    void Start()
    {
        blood.Stop();   
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("krak");
            Destroy(target);
            blood.Play();
        }
    }
}
