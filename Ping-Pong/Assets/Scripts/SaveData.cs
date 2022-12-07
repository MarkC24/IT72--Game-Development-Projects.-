using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public InputField textBox;
    public InputField textBox1;

    public void clickSave()
    {
        PlayerPrefs.SetString("username", textBox.text);
        PlayerPrefs.SetString("username1", textBox1.text);
        SceneManager.LoadScene("SampleScene");
        
    }

}