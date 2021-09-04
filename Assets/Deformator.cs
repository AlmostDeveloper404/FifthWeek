using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Deformator : MonoBehaviour
{
    public Slider height;
    public Slider width;

    public Text widthText;
    public Text heightText;

    public Transform[] Models;

    public GameObject[] ToiletModels;

    int index;

    private void Start()
    {
        height.value = 1.025f;
        width.value = .975f;
    }

    public void ChooseModelVariant(int modelIndex)
    {
        for (int i = 0; i < ToiletModels.Length; i++)
        {
            if (i==modelIndex)
            {
                ToiletModels[i].SetActive(true);
            }
            else
            {
                ToiletModels[i].SetActive(false);
            }
        }
    }
    public void DeformateHeight(float value)
    {
        Models[0].localScale = new Vector3(Models[0].localScale.x, value * 100f, Models[0].localScale.z);
        heightText.text = value.ToString("0.00");
    }

    public void DeformateWidth(float value)
    {
        Models[0].localScale = new Vector3(value * 100f, Models[0].localScale.y, Models[0].localScale.z);
        widthText.text = value.ToString("0.00");
    }

    public void DeformateToiletHeight(float value)
    {
        Models[3].localScale = new Vector3(Models[3].localScale.x, value, Models[3].localScale.z);
        heightText.text = value.ToString("0.00");
    }

    public void DeformateToiletWidth(float value)
    {
        Models[3].localScale = new Vector3(value, Models[3].localScale.y, Models[3].localScale.z);
        widthText.text = value.ToString("0.00");
    }

    public void SetIndex(int _index)
    {
        index = _index;
    }

    public void SetMaterial(Material mat)
    {
        Models[index].GetComponentInChildren<MeshRenderer>().material = mat;
    }
}
