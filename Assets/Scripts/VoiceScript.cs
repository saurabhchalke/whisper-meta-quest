using UnityEngine;
using UnityEngine.UI;

public class VoiceScript : MonoBehaviour
{
    [SerializeField] public Button button;

    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            // trigger button click
            button.onClick.Invoke();
        }
    }
}