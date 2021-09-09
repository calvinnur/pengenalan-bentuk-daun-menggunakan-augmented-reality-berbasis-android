using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GantiScene : MonoBehaviour
{
    public AudioSource ButtonSound;
    public string namascene;

    public void PindahkeScene()
    {
        AudioSource buttonSound = ButtonSound.GetComponent<AudioSource>();
        buttonSound.PlayOneShot(buttonSound.clip);

        Scene sceneini = SceneManager.GetActiveScene();

        if (sceneini.name != namascene)
        {
            SceneManager.LoadScene(namascene);
        }
    }
}
