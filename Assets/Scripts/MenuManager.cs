using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider musicVolume;
    public Slider effectsVolume;
    public Camera camera;
    public AudioSource music;

    void Start()
    {
        Destroy(GameObject.Find("GameManager"));
        Destroy(GameObject.Find("Player"));
        Destroy(GameObject.Find("FloatingTextManager"));

        music = camera.GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void ChangeMusicVolume()
    {
        music.volume = musicVolume.value * 0.6f;
    }

    public void GameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
