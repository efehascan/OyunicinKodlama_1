using UnityEngine;
public class AudioManager : MonoBehaviour


{
    public static AudioManager instance;

    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioSource musicSource;

    [SerializeField] private AudioClip greenBallSound;
    [SerializeField] private AudioClip redBallSound;
    [SerializeField] private AudioClip jumpSound;

    [SerializeField] private AudioClip backgroundMusic;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayGreenBallSound()
    {
        sfxSource.PlayOneShot(greenBallSound);
    }

    public void PlayRedBallSound()
    {
        sfxSource.PlayOneShot(redBallSound);
    }

    public void PlayJumpSound()
    {
        sfxSource.PlayOneShot(jumpSound);
    }
}