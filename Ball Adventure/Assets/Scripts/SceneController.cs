using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject PauseBT;

    private void FixedUpdate()
    {
        if (Input.GetButton("Cancel"))
        {
            PauseGame();
        }
    }

    public static void Restart()
    {
        // Получаем индекс текущей сцены
        int currentSceneID = SceneManager.GetActiveScene().buildIndex;
        // Загружаем сцену по индексу
        SceneManager.LoadScene(currentSceneID);
        // Запускаем время игры если оно было на паузе
        Time.timeScale = 1;
    }
    
    public static void NextLevel()
    {
        // Получаем индекс текущей сцены
        int currentSceneID = SceneManager.GetActiveScene().buildIndex;
        // Прибавляем к текущему индексу единицу
        currentSceneID++;
        // Загружаем сцену по индексу
        SceneManager.LoadScene(currentSceneID);
    }
    
    public void PauseGame()
    { 
        // Останавливаем время
        Time.timeScale = 0;
        //Убираем кнопку паузы
        PauseBT.SetActive(false);
        // Отключаем окно паузы
        PauseMenu.SetActive(true);
    }
    
    public void ResumeGame()
    {
        // Запускаем время
        Time.timeScale = 1;
        //Возвращаем кнопку паузы
        PauseBT.SetActive(true);
        // Выключаем окно паузы
        PauseMenu.SetActive(false);
    }
    
}
