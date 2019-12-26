using UnityEngine;
using System.Collections;

public class SpectrumController : MonoBehaviour
{
	public float speed = 200f;
	
	private readonly int period = 1530;
	private float counter = 0f;
    protected HighlightableObject ho;
    void Awake()
    {
        ho = gameObject.AddComponent<HighlightableObject>();
    }
    void Update() 
    {
        AfterUpdate();
    }
	  void AfterUpdate()
	{
		
		
		int val = (int)counter;
		//Color col = new Color(GetColorValue(1020, val), GetColorValue(0, val), GetColorValue(510, val), 1f);
        Color col = new Color(0f, 1f, 0f, 1f);

        if (Input.GetMouseButtonDown(0) && Start01.part == ho.gameObject )
        {
           
            
            ho.ConstantOnImmediate(col);
        }
        else if (Input.GetMouseButtonUp(0) && Start01.part == ho.gameObject )
        {
            ho.ConstantOffImmediate();
            Start01.part = null;
        }
		
		
		counter += Time.deltaTime * speed;
		counter %= period;
	}
	
	// Some color spectrum magic
	float GetColorValue(int offset, int x)
	{
		int o = 0;
		x = (x - offset) % period;
		if (x < 0)
		{
			x += period;
		}
		
		if (x < 255)
		{
			o = x;
		}
		
		if (x >= 255 && x < 765)
		{
			o = 255;
		}
		
		if (x >= 765 && x < 1020)
		{
			o = 1020 - x;
		}
		
		return (float) o / 255f;
	}
}
