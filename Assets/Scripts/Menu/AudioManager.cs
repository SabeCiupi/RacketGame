using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;
    [Header("Audio Clip")]
    public AudioClip background;
    public AudioClip background2;
    public AudioClip buttons;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    private void Start()
    {
        musicSource.clip = background;
        musicSource.loop = false;
        musicSource.Play();

        StartCoroutine(PlayLoopAfterFirst());
    }

    private System.Collections.IEnumerator PlayLoopAfterFirst()
    {
        yield return new WaitForSeconds(background.length);

        musicSource.clip = background2;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}
