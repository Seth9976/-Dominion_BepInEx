using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000010 RID: 16
	public sealed class DownloadHandlerFile : DownloadHandler
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00002737 File Offset: 0x00000937
		public static IntPtr Create(DownloadHandlerFile obj, string path, bool append)
		{
			return DownloadHandlerFile.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(path), append);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006D58 File Offset: 0x00004F58
		public void InternalCreateVFS(string path, bool append)
		{
			string directoryName = Path.GetDirectoryName(path);
			bool flag = !Directory.Exists(directoryName);
			if (flag)
			{
				Directory.CreateDirectory(directoryName);
			}
			base.m_Ptr = DownloadHandlerFile.Create(this, path, append);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002750 File Offset: 0x00000950
		public override NativeArray<byte> GetNativeData()
		{
			throw new NotSupportedException("Raw data access is not supported");
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000275D File Offset: 0x0000095D
		public override Il2CppStructArray<byte> GetData()
		{
			throw new NotSupportedException("Raw data access is not supported");
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000276A File Offset: 0x0000096A
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported");
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00002789 File Offset: 0x00000989
		public bool removeFileOnAbort
		{
			get
			{
				return DownloadHandlerFile.get_removeFileOnAbortDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerFile.set_removeFileOnAbortDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040000C0 RID: 192
		private static readonly DownloadHandlerFile.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.CreateDelegate>("UnityEngine.Networking.DownloadHandlerFile::Create");

		// Token: 0x040000C1 RID: 193
		private static readonly DownloadHandlerFile.get_removeFileOnAbortDelegate get_removeFileOnAbortDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.get_removeFileOnAbortDelegate>("UnityEngine.Networking.DownloadHandlerFile::get_removeFileOnAbort");

		// Token: 0x040000C2 RID: 194
		private static readonly DownloadHandlerFile.set_removeFileOnAbortDelegate set_removeFileOnAbortDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.set_removeFileOnAbortDelegate>("UnityEngine.Networking.DownloadHandlerFile::set_removeFileOnAbort");

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr path, bool append);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate bool get_removeFileOnAbortDelegate(IntPtr @this);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate void set_removeFileOnAbortDelegate(IntPtr @this, bool value);
	}
}
