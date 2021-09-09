using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public AudioSource Buttonsound;

    public void quitgame()
    {
        AudioSource buttonsound = Buttonsound.GetComponent<AudioSource>();
        buttonsound.PlayOneShot(buttonsound.clip);
        Application.Quit();
    }
}
