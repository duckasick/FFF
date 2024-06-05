using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitScript : MonoBehaviour
{
    public GameObject target;
    public ParticleSystem blood;
    public GameObject player;
    public PlayerMovementAdvanced pam;
    public ShootScript shoot;
    public TextMeshProUGUI wintext;
    public AudioSource death;

    public string level;

    public float shootoff = 15;

    private GotoMainMenu music;

    private bool shit = false;

    private bool fuck = false;
    // Start is called before the first frame update
    void Start()
    {
        blood.Stop();   
    }

    // Update is called once per frame
    void Update()
    {
        if (fuck) pam.state = PlayerMovementAdvanced.MovementState.freeze;
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < shootoff)
        {
            shoot.ShootOff();
        }

        if (wintext.text.Length > 5 && Input.GetKeyDown(KeyCode.Space))
        {
            music = FindObjectOfType<GotoMainMenu>();
            music.Pause();
            SceneManager.LoadScene(level);
        }
        if (!fuck) { blood.Stop(); }

    }

    private void LateUpdate()
    {
        if (!fuck) { blood.Stop(); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("krak");
            wintext.text = "Press Space to continue";
            Destroy(target);
            blood.Play();
            if (shit == false)
            {
                death.Play();
                shit = true;
            }
            fuck = true;
            pam.rb.isKinematic = true;
            player.transform.LookAt(this.transform.position);
        }
    }
}
