//    Copyright 2010 Clinton Sheppard <sheppard@cs.unm.edu>
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Linq;

using FluentWebUITesting.Controls;
using FluentWebUITesting.Extensions;

using OpenQA.Selenium;

namespace gar3t.decuit
{
//	public class RadioButtonOptionSetter : IInputSetter
//	{
//		public bool IsMatch(ControlWrapperBase control)
//		{
//			return control.Element != null && control.ToRadioButtonOptionWrapper().Element != null;
//		}
//
//		public WaitWrapper SetTo(ControlWrapperBase control, string value)
//		{
//			var radioButtonSet = control.Browser.RadioButtonsOptions().Where(x=>x.Id == control.Id).ToList();
//			foreach (var radioButton in radioButtonSet)
//			{
//				var parent = radioButton.Element.GetParent();
//				var siblints = parent.FindElements(By.)
//			}
//			return radioButton.Select();
//		}
//	}
}