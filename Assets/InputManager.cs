using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class InputManager : MonoBehaviour
{


    [SerializeField]
    private GameObject Map;

    private bool mapEnable = true;



    void Start()
    {
        InteractionManager.InteractionSourcePressed += SourcePressed;
    }


    void SourcePressed(InteractionSourcePressedEventArgs state)
    {
        mapEnable = !mapEnable;

        Map.SetActive(mapEnable);

        // Press
    }

}