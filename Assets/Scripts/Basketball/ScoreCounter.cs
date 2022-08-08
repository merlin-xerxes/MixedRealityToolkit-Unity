using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int scoreCounter = 0;
    public Text scoreText;
    [SerializeField] public Image nicKopf0, nicKopf1, nicKopf2, nicKopf3, nicKopf4;
    public AudioClip nic0Sound, nic1Sound, nic2Sound, nic3Sound, nic4Sound;

    public void Start() {
        scoreText.text = "Score:  " + scoreCounter;
    }
    public void Increment()
    {
    scoreCounter++;
    scoreText.text = "Score:  " + scoreCounter;
    if(scoreCounter == 10)
    {
        nicKopf0.enabled = true;
        AudioSource.PlayClipAtPoint(nic0Sound, transform.position, 1);
    }
    if(scoreCounter == 25)
    {
        nicKopf1.enabled = true;
        AudioSource.PlayClipAtPoint(nic1Sound, transform.position, 1);
    }
    if(scoreCounter == 50)
    {
        nicKopf2.enabled = true;
        AudioSource.PlayClipAtPoint(nic2Sound, transform.position, 1);
    }
    if(scoreCounter == 75)
    {
        nicKopf3.enabled = true;
        AudioSource.PlayClipAtPoint(nic3Sound, transform.position, 1);
    }
    if(scoreCounter == 100)
    {
        nicKopf4.enabled = true;
        AudioSource.PlayClipAtPoint(nic4Sound, transform.position, 1);
    }
    }
}
