using System;
using System.Runtime.InteropServices;

namespace VRage.Platform.Windows.DShow
{
	[ComImport]
	[ComVisible(true)]
	[Guid("0579154A-2B53-4994-B0D0-E773148EFF85")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface ISampleGrabberCB
	{
		[PreserveSig]
		int SampleCB(double SampleTime, IMediaSample pSample);

		[PreserveSig]
		int BufferCB(double SampleTime, IntPtr pBuffer, int BufferLen);
	}
}
