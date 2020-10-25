﻿using System;

namespace BlazorWebFormsComponents.Enums
{

	[Flags]
	public enum TreeNodeTypes
	{

		None = 0,
		Root = 1,
		Parent = 2,
		Leaf = 4,
		All = 7,

	}

}
