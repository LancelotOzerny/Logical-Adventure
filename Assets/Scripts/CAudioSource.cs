using UnityEngine;
using YG;

public class CAudioSource : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    private void Start()
    {
        if (YandexGame.savesData.musicOn)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
