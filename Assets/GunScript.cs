using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunScript : MonoBehaviour
{
    public float starttime;
    private float timer;
    public float offset;
    public GameObject beam;
    public bool killed;
    public TextMeshProUGUI killtext;
    public PlayerKillScript PKS;


    public bool sex = true;
    // Start is called before the first frame update
    void Start()
    {
        timer = starttime + offset;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            sex = !sex;
            timer = starttime;
        }
        beam.SetActive(sex);
        if (Input.GetKey(KeyCode.F) && killed == true)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    public void Kill()
    {
        PKS.Kill();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Kill();
            print("turret");
        }
    }

}
