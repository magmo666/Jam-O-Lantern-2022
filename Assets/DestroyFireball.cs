using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFireball : MonoBehaviour
{

    private Vector2 originalPos;

    [SerializeField] private float offset = 20f;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        audioSource.PlayOneShot(clip, volume);
    

}

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > originalPos.x + offset || transform.position.x < originalPos.x - offset)
        {
            Destroy(gameObject);

        }
        if (transform.position.y > originalPos.y + offset || transform.position.y < originalPos.y - offset)
        {
            Destroy(gameObject);

        }
    }

}
