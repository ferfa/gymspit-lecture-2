using System;
using System.Collections.Generic;


namespace Lecture8
{
	interface Expression: IEnumerable<Expression>
	{
		int GetValue();
	}
}
