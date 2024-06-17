using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Switch : MonoBehaviour
{
    public TMP_Dropdown RoomNameDropDown, SceneNameDropDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SwitchSceneCallBack()
    {
        // get current scene name from dropdown
        string sceneToLoad = SceneNameDropDown.options[SceneNameDropDown.value].text;
        if (MySceneManager.Instance != null)
        {
            MySceneManager.Instance.LoadSceneByName(sceneToLoad);
        }
            
    }
    public void RoomChangedCallback()
    {
        // get current room name from dropdown
        string room = RoomNameDropDown.options[RoomNameDropDown.value].text;
        PlayerPrefs.SetString("room", room);
    }
}
