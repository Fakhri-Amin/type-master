using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] explodeSFX;
    [SerializeField] private AudioClip gameOverSFX;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio() => audioSource.PlayOneShot(explodeSFX[Random.Range(0, explodeSFX.Length)]);
}
