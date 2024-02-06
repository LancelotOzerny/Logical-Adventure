using UnityEngine;
using UnityEngine.UI;
using YG;

public class CLevel : MonoBehaviour
{
    [SerializeField] private Image closeArea;
    [SerializeField] private int level = 0;

    private int LastLevel
    {
        get => YandexGame.savesData.lastScene;
    }

    private void Start()
    {
        if (level <= LastLevel)
        {
            closeArea.gameObject.SetActive(false);
        }
    }
}
