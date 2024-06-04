using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    public bool fuck = false;
    public TextMeshProUGUI tmp;
    public RectTransform rect;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();

        // Initialize color, set material color using HSVToRGB.
    }
    void Update()
    {
        if (fuck)
        {
            rect.transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
        }
        // Assign HSV values to float h, s & v. (Since material.color is stored in RGB)
        float h, s, v;
        Color.RGBToHSV(tmp.color, out h, out s, out v);

        // Use HSV values to increase H in HSVToRGB. It looks like putting a value greater than 1 will round % 1 it
        tmp.color = Color.HSVToRGB(h + Time.deltaTime * .25f, s, v);
    }
}
