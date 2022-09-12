using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //Загрузка бесконечного уровня
    public void LoadLuckyLev()
    {
        SceneManager.LoadScene(1);
    }
    //Загрузка 1 уровня
    public void LoadLev1()
    {
        SceneManager.LoadScene(2);
    }
    //Загрузка 2 уровня
    public void LoadLev2()
    {
        SceneManager.LoadScene(3);
    }
    //Загрузка 3 уровня
    public void LoadLev3()
    {
        SceneManager.LoadScene(4);
    }


    //Возвращение в меню
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    //Перезагрузка сцены
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
