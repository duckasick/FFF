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
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1f;
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
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
}
