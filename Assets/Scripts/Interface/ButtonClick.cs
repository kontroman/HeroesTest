using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    //��� ����� ��������� ��� �������, ������� ����� ���� ������� ��� ����� �� ������
    public static void LoadNewScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public static void LoadNewScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public static void ReturnFromTavern()
    {
        HeroPicker.Instance.ReturnFromTavern();
    }
}
