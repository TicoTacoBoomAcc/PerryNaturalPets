using UnityEngine;
using System;
using System.IO;
using Unity.VisualScripting;

[Serializable]
public class Settings
{
    // VV all data you wanna save
    public bool Boyy = false;
    public bool Girll = false;
    public bool Genderr = false;

    private static string path;

    public static void SaveData(Settings data)// < - function to take in data and save to a json file
    {
        path = Application.persistentDataPath;

        string rawJson = JsonUtility.ToJson(data);

        File.WriteAllText(Path.Combine(Application.persistentDataPath, "Settings.json"), rawJson);
    }

    public static Settings LoadData() // <- fucnction to load data, thisll return the data as a Settings class
    {
        path = Application.persistentDataPath;

        if (!File.Exists(path + "Settings.json"))
            return new Settings();

        string rawJson = File.ReadAllText(path + "Settings.json");

        Settings loadedData = JsonUtility.FromJson<Settings>(rawJson);

        return loadedData;
    }
}