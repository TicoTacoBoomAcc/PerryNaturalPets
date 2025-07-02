using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GenderQuest : MonoBehaviour
{
    public SaveData SaveDataa;

    public bool boy;
    public bool girl;
    public bool gender;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boy = false;
        girl = false;
        gender = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Boi()
    {
        boy = true;
        SceneManager.LoadScene(2);
    }

    public void Gal()
    {
        girl = true;
        SceneManager.LoadScene(2);
    }

    public void Gender()
    {
        gender = true;
        SceneManager.LoadScene(2);
    }
}
