using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickData : MonoBehaviour
{
   public void clickpass()
    {
        SceneManager.LoadScene("Second");
    }

     public void clickpass2()
    {
        SceneManager.LoadScene("Setting");
    }
}

