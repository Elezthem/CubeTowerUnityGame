using UnityEngine;

public class isEnabled : MonoBehaviour
{
    public int needToUnLock;
    public Material blackMaterial;

    private void Start()
    {
        if (PlayerPrefs.GetInt("score") < needToUnLock)
            GetComponent<MeshRenderer>().material = blackMaterial;
    }
}
