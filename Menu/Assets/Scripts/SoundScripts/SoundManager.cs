using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Sprite musicSound_On;
    [SerializeField] private Sprite musicSound_Off;
    [SerializeField] private Button musicButton;
    [SerializeField] private Sprite sfxSound_On;
    [SerializeField] private Sprite sfxSound_Off;
    [SerializeField] private Button sfxButton;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Sfx.sfxInstance.musicToggle == true)
            {
                Sfx.sfxInstance.Audio.PlayOneShot(Sfx.sfxInstance.Click);
            }
        }
    }
    private void Start()
    {
        if (BgMusic.BgInstance.Audio.isPlaying)
        {
            musicButton.GetComponent<Image>().sprite = musicSound_On;
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicSound_Off;
        }
        //SFX
        if (Sfx.sfxInstance.musicToggle)
        {
            sfxButton.GetComponent<Image>().sprite = sfxSound_On;
        }
        else
        {
            sfxButton.GetComponent<Image>().sprite = sfxSound_Off;
        }
    }
    public void SfxToggle()
    {
        if (Sfx.sfxInstance.musicToggle)
        {
            Sfx.sfxInstance.musicToggle = false;
            sfxButton.GetComponent<Image>().sprite = sfxSound_Off;
        }
        else
        {
            Sfx.sfxInstance.musicToggle = true;
            sfxButton.GetComponent<Image>().sprite = sfxSound_On;
        }

    }
    public void MusicToggle()
    {
        if (BgMusic.BgInstance.Audio.isPlaying)
        {
            musicButton.GetComponent<Image>().sprite = musicSound_Off;
            BgMusic.BgInstance.Audio.Pause();
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicSound_On;
            BgMusic.BgInstance.Audio.Play();
        }
    }

}
