using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject camera;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.rotation *= Quaternion.Euler(0, speed, 0);
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("LevelTutorial");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
