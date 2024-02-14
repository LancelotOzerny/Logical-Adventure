using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class CLevel : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Image block = null;
    [SerializeField] private Button button = null;
    [SerializeField] private Text levelText = null;

    [Header("Params")]
    [SerializeField] private int level = 1;

    private void OnEnable()
    {
        if (block != null)
        {
            bool blockNone = level <= YandexGame.savesData.lastScene;
            block.gameObject.SetActive(blockNone == false);
        }

        if (levelText != null)
        {
            levelText.text = level.ToString();
        }

        if (button != null)
        {
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(level);
            });
        }
    }
}
