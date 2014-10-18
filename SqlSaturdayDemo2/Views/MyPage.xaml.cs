using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SqlSaturdayDemo2
{	
	public partial class MyPage : ContentPage
	{	
		public MyPage ()
		{
			InitializeComponent ();
			BindingContext = new MyPageViewModel ();
		}
	}
}

