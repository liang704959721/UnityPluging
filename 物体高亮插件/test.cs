using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject m_High;
    private HighlightableObject ho;
    Color col = new Color(0f, 1f, 0f, 1f);
    // Use this for initialization
    void Start()
    {
        ho = m_High.GetComponent<HighlightableObject>();
        ho.ConstantOnImmediate(col);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
