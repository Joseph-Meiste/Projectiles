using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int stars = 0;
    public Text scoreDisplay;
    public Animator scoreAnimator;
    public int nextLevel = 0;
public void EndLevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;

            if (numProjectiles < 2) {
                stars = 3;
                scoreDisplay.text = "Three Stars!";
                scoreAnimator.SetInteger("Stars", 3);
            }
            else if (numProjectiles < 3) {
                stars = 2;
                scoreDisplay.text = "Two Stars!";
                scoreAnimator.SetInteger("Stars", 2);
            }
            else
            {
                stars = 1;
                scoreDisplay.text = "One Stars!";
                scoreAnimator.SetInteger("Stars", 1);
            }
            print("You got " + stars + " stars!!");
            Invoke("NextLevel", 2);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
