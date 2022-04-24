using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Selecting")]
    [SerializeField] AudioClip selectingClip;
    [SerializeField] [Range(0f, 1f)] float selectingVolume = 1f;

    public void PlaySelectingClip()
    {
        if (selectingClip != null)
        {
            AudioSource.PlayClipAtPoint(selectingClip, Camera.main.transform.position, selectingVolume);
        }
    }
}
