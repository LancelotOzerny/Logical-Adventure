
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        public int lastScene = 0;
        public int hindCount = 1;
        public int langIndex = 0;

        public SavesYG()
        {

        }
    }
}
