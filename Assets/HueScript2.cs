using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HueScript2 : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize color, set material color using HSVToRGB.
        GetComponent<TextMeshProUGUI>().color = Color.HSVToRGB(.34f, .84f, .67f);
    }
    void Update()
    {
        // Assign HSV values to float h, s & v. (Since material.color is stored in RGB)
        float h, s, v;
        Color.RGBToHSV(GetComponent<TextMeshProUGUI>().color, out h, out s, out v);

        // Use HSV values to increase H in HSVToRGB. It looks like putting a value greater than 1 will round % 1 it
        GetComponent<TextMeshProUGUI>().color = Color.HSVToRGB(h + Time.deltaTime * .125f, s, v);
    }
}
