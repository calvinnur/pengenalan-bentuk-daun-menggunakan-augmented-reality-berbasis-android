using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindahPanel : MonoBehaviour
{
    public AudioSource ButtonSound;
    public GameObject PanelAwal;
    public GameObject PanelTujuan;

    public void Gantikepanelbaru()
    {

        AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
        buttonSound.PlayOneShot(buttonSound.clip);

        PanelAwal.SetActive(false);
        PanelTujuan.SetActive(true);
    }
}
