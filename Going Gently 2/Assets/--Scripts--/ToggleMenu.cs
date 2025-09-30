using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject menu;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMover>() != null)
        {
            menu.SetActive(true);
        }
    }
}
