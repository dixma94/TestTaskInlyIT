using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class DataSaveLoader : MonoBehaviour
{
    private string dataFilePath;

    public static DataSaveLoader instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
        dataFilePath = Application.persistentDataPath + "/GemData.json";
    }

    public bool IsFileExist()
    {
        return File.Exists(dataFilePath);
    }

    public GemData Load()
    {
        GemData loadedData = null;

        if (IsFileExist())
        {
            try
            {
                string dataToLoad = "";
                using (FileStream stream = new(dataFilePath, FileMode.Open))
                {
                    using (StreamReader reader = new(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }

                loadedData = JsonUtility.FromJson<GemData>(dataToLoad);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occured when trying to load data from file: " + dataFilePath + "\n" + e);
            }
        }
        return loadedData;
    }

    public void Save(GemData data)
    {
        

        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(dataFilePath));

            

            string dataToSource = JsonUtility.ToJson(data, true);
           

            using (FileStream stream = new(dataFilePath, FileMode.Create))
            {
                using (StreamWriter writer = new(stream))
                {
                    writer.Write(dataToSource);
                }
            }

        }
        catch (Exception e)
        {

            Debug.LogError("Error occured when trying to save data to path: " + dataFilePath + "\n" + e);
        }
    }
}

