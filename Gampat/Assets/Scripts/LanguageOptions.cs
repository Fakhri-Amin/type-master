using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LanguageOptions : MonoBehaviour
{
    [SerializeField] private GameObject languageCanvas;
    private ToggleGroup toggleGroup;

    private void Awake()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            languageCanvas.SetActive(false);
        }
        else
        {
            languageCanvas.SetActive(true);
        }
    }

    public void SetCanvasToActive(bool isActive)
    {
        languageCanvas.SetActive(isActive);
    }
}
