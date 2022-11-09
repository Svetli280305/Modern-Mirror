using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] TextMeshProUGUI volumeNumberText;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        volumeNumberText.text = $"{Mathf.Round(volumeSlider.value * 10) / 10}";
    }
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Leve2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Volume(Slider slider)
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
        volumeNumberText.text = $"{Mathf.Round(slider.value * 10) / 10}";

    }
}
