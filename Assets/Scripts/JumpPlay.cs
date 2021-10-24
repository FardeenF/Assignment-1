using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlay : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        PlayerController.jumpPerformed += PlayAudio;
    }

    private void OnDisable()
    {
        PlayerController.jumpPerformed -= PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }

}
