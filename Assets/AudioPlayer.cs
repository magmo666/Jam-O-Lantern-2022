using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    // Start is called before the first frame update
 public AudioSource source;
    private float fadeTime = .8f;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(AudioHelper.FadeIn(source, fadeTime));
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(AudioHelper.FadeOut(source, fadeTime));
        }
    }
}
