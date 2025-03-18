using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform fireSocket;
    public float rationRate = 90.0f;
    public Animator animator;
    public ParticleSystem fireFX;

    public int numProjectiles = 0;

    void Start()
    {
        
    }

    void Update()
    {
        float aimInput = Input.GetAxis("Horizontal");
        aimInput *= rationRate * Time.deltaTime;
        transform.Rotate(Vector3.right * aimInput, Space.World);
    
        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
            numProjectiles++;
        }

    }

    void Fire()
    {
        fireFX.Play();
        animator.SetTrigger("Fire");
        Instantiate(projectilePrefab, fireSocket.position, fireSocket.rotation);
    }
}
