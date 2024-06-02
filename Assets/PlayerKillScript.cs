using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class PlayerKillScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject image;
    public ParticleSystem blood;
    private bool killed;
    public float zero = 0;
    // Start is called before the first frame update
    void Start()
    {
        blood.Stop();
        image.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && killed == true)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    public void Kill()
    {
        print("fuck");
        text.text = "Press F to restart";
        killed = true;
        Time.timeScale = zero;
        image.SetActive(true);

    }
}
