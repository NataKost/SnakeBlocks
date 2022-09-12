using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public Moving snakeHead;
    public GameObject Player;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out snakeHead))
        {
            SceneManager.LoadScene(6, LoadSceneMode.Additive);
            Destroy(Player);
        }
    }
}
