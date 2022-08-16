using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTracker : MonoBehaviour
{
    public GameObject checkbox;
    public AudioClip taskCompleteSound;

    public void Complete()
    {
        checkbox.SetActive(true);
        AudioSource.PlayClipAtPoint(taskCompleteSound, transform.position, 1);
    }
}
