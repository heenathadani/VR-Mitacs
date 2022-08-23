using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    public Transform target;
    Vector3 p;
    
    void Start()
    {
        p = target.position;
        p.x = target.position.x;
        p.y = target.position.y;
        p.z = target.position.z;
    }

    void Update()
    {
        text.text = $"Position : {target.position.ToString()}";
    }
    
    public void PositionIncrease()
    {
        p.y += .2f;
        p.x += .5f;
        p.z += .3f;
    }

    public void SavePosition()
    {
        PlayerPrefs.SetFloat("updatedX:", p.x);
        PlayerPrefs.SetFloat("updatedY:", p.y);
        PlayerPrefs.SetFloat("updatedZ:", p.z);
    }
}
