using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] protected VideoPlayer videoPlayer;
    [SerializeField] protected Button playButton;
    [SerializeField] protected Button replayButton;
    [SerializeField] protected Button pauseButton;
    [SerializeField] protected TMP_Dropdown videoDropDown;
    [SerializeField] protected List<VideoClip> videoClips;

    protected virtual void Start()
    {
        playButton.onClick.AddListener(Play);
        replayButton.onClick.AddListener(Replay);
        pauseButton.onClick.AddListener(Pause);
        videoDropDown.onValueChanged.AddListener(ChangeVideo);
    }

    protected virtual void Play()
    {
        videoPlayer.Play();
    }

    protected virtual void Replay()
    {
        videoPlayer.Stop();
    }

    protected virtual void Pause()
    {
        videoPlayer.Pause();
    }

    protected virtual void ChangeVideo(int index)
    {
        videoPlayer.clip = videoClips[index];
        Play();
    }
}
