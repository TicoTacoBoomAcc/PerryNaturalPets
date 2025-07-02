using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject TitleCard;
    public GameObject PlayButt;
    public GameObject GenderSelect;
    public GameObject MusicMain;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TitleCard.SetActive(true);
        PlayButt.SetActive(true);
        GenderSelect.SetActive(false);
        MusicMain.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        TitleCard.SetActive(false);
        PlayButt.SetActive(false);
        GenderSelect.SetActive(true);
        MusicMain.SetActive(false);
    }
}
