using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GotoMainMenu : MonoBehaviour
{
    public Slider slider;
    public float yourmom;
    private AudioSource music;
    private bool cock;

    public static GotoMainMenu playerInstance;
    void Awake()
    {   
        Object.DontDestroyOnLoad(gameObject);

        if (playerInstance != null)
        {
            Destroy(gameObject);
        }

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        print(GameObject.FindGameObjectsWithTag("KAK"));
        {
            print("IOASDUISAUHDLIOAUHSDIOUHASDIOUHASDOHIUSHIOSDIOHIOUSDAIOUHSADADIOUHSADSUHIOUHIODAHIOUAHDIOAHISD");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("KUUB") != null && !music.isPlaying)
            // waarom werkt find objectswithtag altijd?
        {
            music.Play();
        }
        if (GameObject.FindWithTag("KUUB") == null) { music.Pause(); }
        if (slider != null)
        {
            yourmom = slider.value;
        }
        //print(yourmom);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelMain");
        }
    }

    public void Pause()
    {
        music.Pause();
    }
}
