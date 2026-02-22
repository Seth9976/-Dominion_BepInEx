using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Tests
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class SA_TestConfig : Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000029CC File Offset: 0x00000BCC
		// Note: this type is marked as 'beforefieldinit'.
		static SA_TestConfig()
		{
			Il2CppClassPointerStore<SA_TestConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_TestConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestConfig>.NativeClassPtr);
			SA_TestConfig.NativeFieldInfoPtr_StopsNextTestsIfFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestConfig>.NativeClassPtr, "StopsNextTestsIfFail");
			SA_TestConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestConfig>.NativeClassPtr, 100663314);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002A24 File Offset: 0x00000C24
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_TestConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020B2 File Offset: 0x000002B2
		public SA_TestConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000020BB File Offset: 0x000002BB
		public unsafe bool StopsNextTestsIfFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestConfig.NativeFieldInfoPtr_StopsNextTestsIfFail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestConfig.NativeFieldInfoPtr_StopsNextTestsIfFail)) = value;
			}
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_StopsNextTestsIfFail;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
