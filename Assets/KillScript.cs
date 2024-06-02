using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float scale;
    public GameObject target;
    private bool win;
    private bool once = true;
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
        if (Input.GetKeyDown(KeyCode.W) && once == true)
        {
            scale = 1f;
            Time.timeScale = scale;
            text.text = "";
            once = false;
        }
        if (Input.GetKey(KeyCode.F))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);

        }
        if (win)
        {
            //
        }
    }

    public void Win()
    {
        win = true;
    }
}
