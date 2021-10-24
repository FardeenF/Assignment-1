using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlay : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        LevelEditor.placeBlock += PlayAudio;
    }

    private void OnDisable()
    {
        LevelEditor.placeBlock += PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }

}
