using System.Collections;
using UnityEngine;

public class CookPizza : MonoBehaviour
{
    public GameObject rawPizza;
    public GameObject mushroomLayer;
    public GameObject cookedPizza;

    public Renderer bakeIndicator;

    private bool pizzaInOven = false;
    private bool isBaking = false;

    private void Start()
    {
        bakeIndicator.material.DisableKeyword("_EMISSION");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == rawPizza && mushroomLayer.activeSelf)
        {
            pizzaInOven = true;
            rawPizza.SetActive(false);
        }
    }

    public void BakePizza()
    {
        if (pizzaInOven && !isBaking)
        {
            StartCoroutine(Bake());
        }
    }

    private IEnumerator Bake()
    {
        isBaking = true;

        // Turn indicator ON
        bakeIndicator.material.EnableKeyword("_EMISSION");

        // Wait 3 seconds
        yield return new WaitForSeconds(3f);

        // Finish pizza
        cookedPizza.SetActive(true);

        // Turn indicator OFF
        bakeIndicator.material.DisableKeyword("_EMISSION");

        pizzaInOven = false;
        isBaking = false;
    }
}