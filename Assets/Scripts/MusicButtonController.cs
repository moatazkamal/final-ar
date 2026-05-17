using UnityEngine;

public class MusicButtonController : MonoBehaviour
{
    public AudioSource backgroundMusic;

    public void PlayMusic()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.Play();
        }
    }

    public void StopMusic()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.Stop();
        }
    }

    public void ToggleMusic()
    {
        if (backgroundMusic == null)
            return;

        if (backgroundMusic.isPlaying)
        {
            backgroundMusic.Pause();
        }
        else
        {
            backgroundMusic.Play();
        }
    }
}