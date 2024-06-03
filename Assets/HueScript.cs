using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HueScript : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        // Initialize color, set material color using HSVToRGB.
        light.color = Color.HSVToRGB(.34f, .84f, .67f);
    }
    void Update()
    {
        // Assign HSV values to float h, s & v. (Since material.color is stored in RGB)
        float h, s, v;
        Color.RGBToHSV(light.color, out h, out s, out v);

        // Use HSV values to increase H in HSVToRGB. It looks like putting a value greater than 1 will round % 1 it
        light.color = Color.HSVToRGB(h + Time.deltaTime * .25f, s, v);
    }
}
