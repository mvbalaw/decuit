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
//    limitations under the License.using OpenQA.Selenium;

using OpenQA.Selenium;

namespace gar3t.decuit
{
	public static class SetterFor
	{
		public static SetByLabelExpression ControlWithLabel(IWebDriver browser, string labelText)
		{
			return new SetByLabelExpression(browser, labelText);
		}

		public static SetByIdExpression ControlWithId(IWebDriver browser, string id)
		{
			return new SetByIdExpression(browser, id);
		}
	}
}