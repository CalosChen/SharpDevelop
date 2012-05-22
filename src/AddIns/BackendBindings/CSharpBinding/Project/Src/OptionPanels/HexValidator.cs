﻿/*
 * Created by SharpDevelop.
 * User: Peter Forstmeier
 * Date: 22.05.2012
 * Time: 20:46
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;
using System.Windows.Controls;

namespace CSharpBinding.OptionPanels
{
	/// <summary>
	/// Description of HexValidator.
	/// </summary>
	public class  HexValidator :ValidationRule
	{
//		http://www.codeproject.com/Articles/15239/Validation-in-Windows-Presentation-Foundation
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			ValidationResult result = new ValidationResult(true, null);
			var str = value.ToString();
			var y = 0;
			var res = Int32.TryParse(str,NumberStyles.HexNumber,CultureInfo.InvariantCulture,out y);
			if (!res) {
				 result = new ValidationResult(false, "No Valid hex Digit");
			}
			return result;
		}
	}
}
