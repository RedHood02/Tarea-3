using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneChangeMaster : MonoBehaviour
{
    [SerializeField] RawImage roofImage, floorImage, doorImage;
    [SerializeField] Image chimneyImage;

    //Door
    public void DoorToRoof()
    {
        doorImage.gameObject.SetActive(false);
        roofImage.gameObject.SetActive(true);
    }

    public void DoorToChimney()
    {
        doorImage.gameObject.SetActive(false);
        chimneyImage.gameObject.SetActive(true);
    }

    public void DoorToFloor()
    {
        doorImage.gameObject.SetActive(false);
        floorImage.gameObject.SetActive(true);
    }

    //Chimney
    public void ChimenyToDoor()
    {
        chimneyImage.gameObject.SetActive(false);
        doorImage.gameObject.SetActive(true);
    }

    //Roof
    public void RoofToDoor()
    {
        roofImage.gameObject.SetActive(false);
        doorImage.gameObject.SetActive(true);
    }

    //Floor
    public void FloorToDoor()
    {
        floorImage.gameObject.SetActive(false);
        doorImage.gameObject.SetActive(true);
    }
}
