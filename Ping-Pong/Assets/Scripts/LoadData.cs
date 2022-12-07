using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
   public Text UserNameBox;
   public Text UserNameBox1;
    // Start is called before the first frame update
    void Start()
    {
        UserNameBox.text = PlayerPrefs.GetString("username");
        UserNameBox1.text = PlayerPrefs.GetString("username1");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("First");
    }
}
