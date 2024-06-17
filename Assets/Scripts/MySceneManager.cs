using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MySceneManager : MonoBehaviour
{
    
    // Static instance of
    public static MySceneManager Instance { get; private set; }
    // Start is called before the first frame update
    void Awake()
    {
        // Check if an instance already exists
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        // assign
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadAssembly()
    {
        SceneManager.LoadScene("Assembly");
    }
    public void LoadRivian()
    {
        SceneManager.LoadScene("Rivian");
    }
    public void LoadAlignment()
    {
        SceneManager.LoadScene("AlignmentScene");
    }
    public void LoadSceneByName(string scene)
    {
        SceneManager.LoadScene(scene);
    }


}
