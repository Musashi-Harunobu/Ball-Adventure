using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static void Restart()
    {
        // Получаем индекс текущей сцены
        int currentSceneID = SceneManager.GetActiveScene().buildIndex;
        // Загружаем сцену по индексу
        SceneManager.LoadScene(currentSceneID);
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
    
}
