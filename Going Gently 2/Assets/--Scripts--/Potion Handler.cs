using TMPro;
using UnityEngine;

public class PotionHandler : MonoBehaviour
{
    public bool hasIngredient1 = false;
    public bool hasIngredient2 = false;
    public bool hasIngredient3 = false;
    private bool isIngredient1Used = false;
    private bool isIngredient2Used = false;
    private bool isIngredient3Used = false;
    public TextMeshProUGUI dadText;


    public void UseIngredient(int ingredientToToggle)
    {
        if (ingredientToToggle == 1)
        {
            hasIngredient1 = false;
            isIngredient1Used = true;
        }
        if (ingredientToToggle == 2)
        {
            hasIngredient2 = false;
            isIngredient2Used = true;
        }
        if (ingredientToToggle == 3)
        {
            hasIngredient3 = false;
            isIngredient3Used = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Father")
        {
            dadText = collision.gameObject.GetComponentInChildren<TextMeshProUGUI>();
            if (isIngredient1Used && isIngredient2Used && isIngredient3Used)
            {
                dadText.text = "Wow I'm suddenly cured of all physical ailments. Surely this will happen just as easily in the full game. :)";
            }
        }
    }
}
