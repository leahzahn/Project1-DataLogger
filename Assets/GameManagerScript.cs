using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManagerScript : MonoBehaviour
{
    public string filepath;
    // Start is called before the first frame update
    void Start()
    {
        CreateFile();
        WriteFile("Application startup");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateFile()
    {
        if (!File.Exists(filepath))
        {
            File.Create(filepath).Close();
        }
    }

    private void WriteFile(string text)
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            writer.WriteLine(text);
        }
    }

}
