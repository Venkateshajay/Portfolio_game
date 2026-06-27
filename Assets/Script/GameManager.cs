using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    [SerializeField] VideoPlayer[] videos;
    private void Start()
    {
        videos[0].url = System.IO.Path.Combine(Application.streamingAssetsPath, "Strawberry.mp4");
        videos[1].url = System.IO.Path.Combine(Application.streamingAssetsPath, "Bobs.mp4");
        videos[2].url = System.IO.Path.Combine(Application.streamingAssetsPath, "Bang_Bang.mp4");
        videos[3].url = System.IO.Path.Combine(Application.streamingAssetsPath, "Penalty_Shooter.mp4");
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }
}
