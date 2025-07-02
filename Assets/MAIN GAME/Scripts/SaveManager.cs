using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SaveManager : MonoBehaviour
{
    public Settings settings;

    private void Start()
    {


        settings = Settings.LoadData();


        Debug.Log(Application.persistentDataPath);
    }

    private void Update()
    {

    }

    public void Boi()
    {
        Settings.SaveData(settings);
        {
            settings.Boyy = true;
            settings.Girll = false;
            settings.Genderr = false;
        }

        SceneManager.LoadScene(2);
    }

}
