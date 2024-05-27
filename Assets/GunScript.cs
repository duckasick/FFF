using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float starttime;
    private float timer;
    public GameObject beam;
    private bool sex = true;
    // Start is called before the first frame update
    void Start()
    {
        timer = starttime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            sex = !sex;
            timer = starttime;
        }
        beam.SetActive(sex);

    }
}
