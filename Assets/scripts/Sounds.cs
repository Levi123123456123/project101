using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audiosourse =>GetComponent<AudioSource>();
    public AudioClip [] sounds;
    public void PlaySound(AudioClip clip, float volume=1f,bool destroyed = false, float pl1=0.85f, float pl2=1.2f)
    {
        audiosourse.pitch = Random.Range(pl1,pl2);
        if (destroyed)
            AudioSource.PlayClipAtPoint(clip, transform.position,volume);
        else
            audiosourse.PlayOneShot(clip,volume);
    }
}