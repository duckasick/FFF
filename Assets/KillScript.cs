using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float scale;
    private bool FUCK;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        scale = 0;
        Time.timeScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = scale;
        if (Input.GetKeyDown(KeyCode.W))
        {
            scale = 1f;
            text.text = "";
        }
        if (Input.GetKey(KeyCode.F))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);

        }
    }
}
