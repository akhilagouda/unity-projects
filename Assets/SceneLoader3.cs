using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader3: MonoBehaviour
{
    // Function to load the next scene
    public void LoadScene()
    {
        SceneManager.LoadScene("S3");
    }
}