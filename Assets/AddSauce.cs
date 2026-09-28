using UnityEngine;

public class AddSauce : MonoBehaviour
{
    public GameObject sauceLayer;
    public GameObject cheeseLayer;
    public GameObject mushroomLayer;
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Can_01_Open") {
            sauceLayer.SetActive(true);
        }
        if (collision.gameObject.name == "Cheese Wedge" && sauceLayer.activeSelf){
            cheeseLayer.SetActive(true);
        }
        if (collision.gameObject.name == "Mushroom Family" && cheeseLayer.activeSelf) {
            mushroomLayer.SetActive(true);
        }
    }
}
