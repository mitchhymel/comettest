using System;
using Android.App;
using Android.Runtime;
using Microsoft.Maui;

namespace maui6
{
	[Application]
	public class MainApplication : MauiApplication<Startup>
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}
	}
}