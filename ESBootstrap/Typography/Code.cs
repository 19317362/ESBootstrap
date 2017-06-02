﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;


namespace ESBootstrap
{
	public class Code : Widget
	{
		public Code(params Union<string, Widget, HTMLElement>[] typos) : base(Document.CreateElement("code"), typos)
		{

		}
	}
}
