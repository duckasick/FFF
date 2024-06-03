using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatScript : MonoBehaviour
{
    float time;
    public float amp;
    public float freq;
    public bool floating;
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        print(Mathf.Sin(time));
        if (floating)
        {
            this.transform.position += new Vector3(0, Mathf.Sin(time * freq) * amp, 0);
        }
    }
}
