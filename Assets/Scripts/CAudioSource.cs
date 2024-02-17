using UnityEngine;
using YG;

public class CAudioSource : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private bool playOnStart = true;

    private void Awake()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    private void Start()
    {
        if (YandexGame.savesData.musicOn && playOnStart)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }

    public void Play()
    {
        if (YandexGame.savesData.musicOn)
        {
            audioSource.Play();
        }
    }
}
