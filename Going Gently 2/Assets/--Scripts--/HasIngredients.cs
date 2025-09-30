using UnityEngine;


public class HasIngredients : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);   
    }
    public bool hasIngredient1 = false;
    public bool hasIngredient2 = false;
    public bool hasIngredient3 = false;

    public void ToggleIngredient(int ingredientToToggle)
    {
        if (ingredientToToggle == 1)
        {
            hasIngredient1 = !hasIngredient1;
        }
        if (ingredientToToggle == 2)
        { 
            hasIngredient2 = !hasIngredient2;
        }
        if (ingredientToToggle == 3)
        {
            hasIngredient3 = !hasIngredient3;
        }
    }
}
