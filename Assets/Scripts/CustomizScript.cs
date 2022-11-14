using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomizScript : MonoBehaviour
{
    public GameObject[] _meshes;
    
    public void Customiz_button(int mesh_ID)
    {
        _meshes[mesh_ID].SetActive(true);
        if (mesh_ID == 0) _meshes[1].SetActive(false);
        else if (mesh_ID == 1) _meshes[0].SetActive(false);
        else if (mesh_ID == 2) _meshes[3].SetActive(false);
        else if (mesh_ID == 3) _meshes[2].SetActive(false);
        else if (mesh_ID == 4) _meshes[5].SetActive(false);
        else if (mesh_ID == 5) _meshes[4].SetActive(false);
        else if (mesh_ID == 6) _meshes[7].SetActive(false);
        else if (mesh_ID == 7) _meshes[6].SetActive(false);
    }
}
