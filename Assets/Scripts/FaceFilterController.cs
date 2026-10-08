using UnityEngine;

public class FaceFilterController : MonoBehaviour
{
    public GameObject hat;

    public void ShowHat()
    {
        hat.SetActive(true);
    }

    public void RemoveHat()
    {
        hat.SetActive(false);
    }
}
