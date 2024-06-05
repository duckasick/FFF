using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAudioScript : MonoBehaviour
{
    private AudioSource au; 
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();
        au.time = Random.value * (au.clip.length - 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
