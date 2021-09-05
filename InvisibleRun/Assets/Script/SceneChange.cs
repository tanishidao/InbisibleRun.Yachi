using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    public void JumpMain()
    {
        SceneManager.LoadScene("MainScene");
    }
public void JumpStart()
    {
        SceneManager.LoadScene("StartScene");
    }

}
