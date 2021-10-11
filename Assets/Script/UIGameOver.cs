using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    private void Update()
    {

    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
