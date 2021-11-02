using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlay : MonoBehaviour
{
    private AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        LaunchProjectile.shootProjectile += PlayAudio;
    }

    private void OnDisable()
    {
        LaunchProjectile.shootProjectile += PlayAudio;
    }

    private void PlayAudio()
    {
        _audiosource.Play();
    }
}
