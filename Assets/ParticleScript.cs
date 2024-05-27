using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
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
}
