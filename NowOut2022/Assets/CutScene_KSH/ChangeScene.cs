using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeScene : MonoBehaviour
{
    float timer;
    int waitingTime;
    public VideoPlayer videoClip;
    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer > videoClip.length)
        {
            LoadScene();
        }
    }
  public void LoadScene()
    {
        SceneManager.LoadScene("Episode1_LJY");
    }

  
}
