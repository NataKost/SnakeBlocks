using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //�������� ������������ ������
    public void LoadLuckyLev()
    {
        SceneManager.LoadScene(1);
    }
    //�������� 1 ������
    public void LoadLev1()
    {
        SceneManager.LoadScene(2);
    }
    //�������� 2 ������
    public void LoadLev2()
    {
        SceneManager.LoadScene(3);
    }
    //�������� 3 ������
    public void LoadLev3()
    {
        SceneManager.LoadScene(4);
    }


    //����������� � ����
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    //������������ �����
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
