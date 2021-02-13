using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class GameManagerScript : MonoBehaviour
{
    public string filepath;
    // Start is called before the first frame update
    void Start()
    {
        CreateFile();
        WriteFile("Application startup at " + DateTime.Now);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            WriteFile("Space key pressed at " + DateTime.Now);
        }
    }

    private void OnApplicationQuit()
    {
        WriteFile("Application quit at " + DateTime.Now);
    }

    public void Click()
    {
        WriteFile("Button clicked at " + DateTime.Now);
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
        using (StreamWriter writer = new StreamWriter(filepath, true))
        {
            writer.WriteLine(text);
        }
    }

    
}
