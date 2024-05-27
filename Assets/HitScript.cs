using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    public GameObject target;
    public ParticleSystem blood;
    public GameObject player;
    public PlayerMovementAdvanced pam;

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
