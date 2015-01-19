using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
    private static AudioManager Instance;

    public bool Desativar_BGM = false;
    public bool Desativar_SFX = false;

    public float Master_Volume = 1.0f;
    public float BGM_Volume = 0.8f;
    public float SFX_Volume = 0.6f;

    public GameObject AudioSourcePrefab;
    public AudioClip[] clips;
    private Hashtable nameClipHash;


    void Awake() {
        Instance = this;
    }

    void Start() {
        nameClipHash = new Hashtable();

        foreach (AudioClip clip in clips) {
            nameClipHash.Add(clip.name, clip);
        }
    }



    private float GenerateVariation(float limit) {
        return (Random.value * 2 - 1) * limit;
    }


    #region BGM

    public static void PlayBGM(string name) {
        Instance._PlayBGM(name);
    }
    public static void PauseBGM() {
        Instance.audio.Pause();
    }
    public static void StopBGM() {
        Instance.audio.Stop();
    }
    public static void SetBGMVolume(float volume) {
        Instance._SetBGMVolume(volume);
    }


    private void _PlayBGM(string name) {
        if (Desativar_BGM) {
            return;
        }

        float volume = 1f;
        volume *= BGM_Volume;
        volume *= Master_Volume;
        volume = Mathf.Clamp(volume, 0, 1);

        AudioClip clip = (AudioClip)nameClipHash[name];
        audio.clip = clip;
        audio.volume = volume;
        audio.pitch = 1f;
        audio.loop = true;

        audio.Play();
    }
    private void _SetBGMVolume(float volume) {
        BGM_Volume = volume;

        volume *= Master_Volume;
        volume = Mathf.Clamp(volume, 0, 1);

        audio.volume = volume;
    } 

    #endregion


    #region SFX

    public static void PlaySFX(string name, Vector3 position, float volume = 1f, float pitch = 1f, float delay = 1f, float volume_variation = 0f, float pitch_variation = 0f) {
        Instance._PlaySFX(name, position, volume, pitch, delay, volume_variation, pitch_variation);
    }


    private void _PlaySFX(string name, Vector3 position, float volume, float pitch, float delay, float volume_variation, float pitch_variation) {
        if (Desativar_SFX) {
            return;
        }

        float vvar = GenerateVariation(volume_variation);
        volume += vvar;
        volume *= SFX_Volume;
        volume *= Master_Volume;
        volume = Mathf.Clamp(volume, 0, 1);

        float pvar = GenerateVariation(pitch_variation);
        pitch += pvar;
        pitch = (pitch < 0) ? 0 : pitch;

        AudioClip clip = (AudioClip)nameClipHash[name];

        GameObject go = (GameObject)Instantiate(AudioSourcePrefab, position, Quaternion.identity);
        go.audio.clip = clip;
        go.audio.volume = volume;
        go.audio.pitch = pitch;
        go.transform.parent = Temp.Audio;

        Selfdestruct sd = go.GetComponent<Selfdestruct>();
        sd.Delay = clip.length + 0.2f;

        go.audio.PlayDelayed(delay);
    }

    #endregion
}
