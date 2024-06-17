using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class VignetteSceneManager
{
    static void LoadAssembly()
    {
        SceneManager.LoadScene("Assembly");
    }
    static void LoadRivian()
    {
        SceneManager.LoadScene("Rivian");
    }
    static void LoadAlignment()
    {
        SceneManager.LoadScene("AlignmentScene");
    }
    static void LoadCups()
    {

    }
    public static void CouldNotLocalizeAnchors()
    {
        if (SceneManager.GetActiveScene().name == "AlignmentScene")
        {


        }
        else
        {

            LoadAlignment();
        }
    }

    public static void CouldNotLoadAnchorsFromFile()
    {
        if (SceneManager.GetActiveScene().name == "AlignmentScene")
        {
            // Do nothing
        }
        else
        {
            // load the anchor setting scene
            LoadAlignment();
        }
    }

    public static void LocalizedAnchors()
    {
        // Anchors loaded and localized. Go to main scene

        if (SceneManager.GetActiveScene().name == "AlignmentScene")
        {
            // go to the assembly scene
            LoadAssembly();
        }
        else
        {
            // do nothing

        }
    }

    public static void LoadAlignmentScene()
    {
        LoadAlignment();
    }

    public static void LoadVignetteScene()
    {
        // go to the assembly scene
        LoadAssembly();
    }
}
