using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200019C RID: 412
	public static class VirtualFileSystem
	{
		// Token: 0x06001C12 RID: 7186 RVA: 0x00061CC8 File Offset: 0x0005FEC8
		public unsafe static bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize)
		{
			VirtualFileSystem.GetLocalFileSystemNameDelegate getLocalFileSystemNameDelegateField = VirtualFileSystem.GetLocalFileSystemNameDelegateField;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(vfsFileName);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(localFileName);
			return getLocalFileSystemNameDelegateField(intPtr, &intPtr2, out localFileOffset, out localFileSize);
		}

		// Token: 0x040015D5 RID: 5589
		private static readonly VirtualFileSystem.GetLocalFileSystemNameDelegate GetLocalFileSystemNameDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.GetLocalFileSystemNameDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName");

		// Token: 0x02000A8F RID: 2703
		// (Invoke) Token: 0x06003322 RID: 13090
		private delegate bool GetLocalFileSystemNameDelegate(IntPtr vfsFileName, [Out] IntPtr localFileName, [Out] IntPtr localFileOffset, [Out] IntPtr localFileSize);
	}
}
