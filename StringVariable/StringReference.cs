using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StringReference
{
    public bool UseConstant = true;
    public string ConstantValue = "";
    public StringVariable Variable = null;

    public StringReference()
    {

    }
    public string Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
        set
		{
			if (UseConstant)
				ConstantValue = value;
			else
				Variable.Value = value;
		}
    }

}
