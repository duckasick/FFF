using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Transform barrel;
    public GameObject target;
    public GameObject bulletPrefab;
    public float speed;
    public float rof;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = rof;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform.position);
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            var bullet = Instantiate(bulletPrefab, barrel.position, barrel.rotation);
            bullet.GetComponent<Rigidbody>().velocity = barrel.forward * speed;
            timer = rof;
        }
    }

    public void ShootOff()
    {
        timer = 999999;
        print("fuckfuckfuck");
    }
}
