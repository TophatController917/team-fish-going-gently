using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string sceneToLoadStr;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMover>() != null)
        {
            SceneManager.LoadScene(sceneToLoadStr);
        }
    }
}
