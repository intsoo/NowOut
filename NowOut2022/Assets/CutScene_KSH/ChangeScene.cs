using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeScene : MonoBehaviour
{
    float timer;
    public VideoPlayer videoClip;
    public AudioSource audioSource;
    public bool HasDoneTutorial;
    void Awake()
    {
        HasDoneTutorial = PlayerPrefs.HasKey("HasDoneTutorial");
        timer = 0;

        if (HasDoneTutorial)
        {
            SceneManager.LoadScene("TestScene");
        }

        //videoClip.controlledAudioTrackCount = 1;             
        //videoClip.EnableAudioTrack(0, true);
        //videoClip.SetTargetAudioSource(0, audioSource);
    }

    void Update()
    {
        
        timer += Time.deltaTime;
         if (timer >= videoClip.length)
        {
            LoadScene();
            return;
        
        }
    }

    void LoadScene()
    {
        PlayerPrefs.SetInt("HasDoneTutorial", 1);
        SceneManager.LoadScene("TestScene");
    }
  
}
