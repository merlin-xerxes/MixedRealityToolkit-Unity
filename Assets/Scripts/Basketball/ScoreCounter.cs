using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int scoreCounter = 0;
    public Text scoreText;
    [SerializeField] public Image image0, image1, image2, image3, image4;
    public AudioClip sound0, sound1, sound2, sound3, sound4;

    public void Start() {
        scoreText.text = "Score:  " + scoreCounter;
    }
    
    public void Increment()
    {
        scoreCounter++;
        scoreText.text = "Score:  " + scoreCounter;
        checkMilestone();
    }

    private void checkMilestone()
    {
        switch(scoreCounter)
        {
            case 10:
                image0.enabled = true;
                AudioSource.PlayClipAtPoint(sound0, transform.position, 1);
            break;
            case 25:
                image1.enabled = true;
                AudioSource.PlayClipAtPoint(sound1, transform.position, 1);
            break;
            case 50:
                image2.enabled = true;
                AudioSource.PlayClipAtPoint(sound2, transform.position, 1);
            break;
            case 75:
                image3.enabled = true;
                AudioSource.PlayClipAtPoint(sound3, transform.position, 1);
            break;
            case 100:
                image4.enabled = true;
                AudioSource.PlayClipAtPoint(sound4, transform.position, 1);
            break;
            default:
            break;
        }
    }
}
