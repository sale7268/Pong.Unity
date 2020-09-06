using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnSoundEffects : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource myfx;
    public AudioClip hoverfx;
    public AudioClip clickfx;

    public void HoverSound()
    {
        myfx.PlayOneShot(hoverfx);
    }
    public void ClickSound()
    {
        myfx.PlayOneShot(clickfx);
    }
}
