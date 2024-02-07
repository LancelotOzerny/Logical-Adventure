using UnityEngine;
using UnityEngine.Events;
using YG;

public class CMusic : MonoBehaviour
{
    [SerializeField] private UnityEvent on;
    [SerializeField] private UnityEvent off;

    [SerializeField] private bool MusicOn
    {
        get => YandexGame.savesData.musicOn;
        set
        {
            YandexGame.savesData.musicOn = value;
            YandexGame.SaveProgress();
        }
    }

    private void Awake()
    {
        Invoke();
    }

    public void ChangeState()
    {
        MusicOn = !MusicOn;
        Invoke();
    }

    private void Invoke()
    {
        if (MusicOn)
        {
            on.Invoke();
        }
        else 
        {
            off.Invoke();
        }
    }
}
