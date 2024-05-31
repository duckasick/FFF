using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    public GameObject target;
    public ParticleSystem blood;
    public GameObject player;
    public PlayerMovementAdvanced pam;
    public ShootScript shoot;

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
        if (distance < 15)
        {
            shoot.ShootOff();
        }

    }

    private void LateUpdate()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("krak");
            Destroy(target);
            blood.Play();
            fuck = true;
            pam.rb.isKinematic = true;
            player.transform.LookAt(this.transform.position);
        }
    }
}
