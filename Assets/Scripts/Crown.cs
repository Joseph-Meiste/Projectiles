using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Score score = FindObjectOfType<Score>();
            if (score)
            {
                score.EndLevel();
            }

            if (explosion)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
