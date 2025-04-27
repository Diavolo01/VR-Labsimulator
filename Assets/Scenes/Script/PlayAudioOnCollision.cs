using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnCollision : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;
    public string targetTag;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(targetTag))
        {
            source.PlayOneShot(clip);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
