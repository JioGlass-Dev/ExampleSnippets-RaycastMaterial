using JMRSDK.InputModule;
using JMRSDK.UX;
using UnityEngine;

namespace JMRSDKExampleSnippets
{
    /// <summary>
    /// Changes Raycast Material to the focused object and select button is triggered.
    /// </summary>
    public class ChangeRaycastMaterial : MonoBehaviour, ISelectClickHandler
    {
        /// <summary>
        /// PointerLaserUnity holds reference to the material of raycast line renderer
        /// </summary>
        [HideInInspector] public PointerLaserUnity laser;

        /// <summary>
        /// On select button click assign the focused object material to the raycast material.
        /// </summary>
        /// <param name="eventData">
        /// Data related to select click event
        /// </param>
        public void OnSelectClicked(SelectClickEventData eventData)
        {
            if (laser == null)
            {
                laser = FindObjectOfType<PointerLaserUnity>();
                if (laser == null)
                {
                    Debug.LogError("Pointer Laser Missing!");
                    return;
                }
            }
            laser.LineMaterial = this.GetComponent<MeshRenderer>().material;
        }
    }
}