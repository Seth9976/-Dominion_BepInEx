using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Utility
{
	// Token: 0x02000017 RID: 23
	public class SA_Plugins : Object
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000067A4 File Offset: 0x000049A4
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Plugins()
		{
			Il2CppClassPointerStore<SA_Plugins>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_Plugins");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Plugins>.NativeClassPtr);
			SA_Plugins.NativeMethodInfoPtr_OnDisabledAPIUseAttempt_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Plugins>.NativeClassPtr, 100663420);
			SA_Plugins.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Plugins>.NativeClassPtr, 100663421);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000067FC File Offset: 0x000049FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99188, XrefRangeEnd = 99201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnDisabledAPIUseAttempt(string pluginName, string APIname)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pluginName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(APIname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Plugins.NativeMethodInfoPtr_OnDisabledAPIUseAttempt_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006844 File Offset: 0x00004A44
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Plugins()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Plugins>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Plugins.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002213 File Offset: 0x00000413
		public SA_Plugins(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabledAPIUseAttempt_Public_Static_Void_String_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
