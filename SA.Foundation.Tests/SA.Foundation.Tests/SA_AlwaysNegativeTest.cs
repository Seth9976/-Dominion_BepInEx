using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace SA.Foundation.Tests
{
	// Token: 0x02000003 RID: 3
	public class SA_AlwaysNegativeTest : SA_BaseTest
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002654 File Offset: 0x00000854
		// Note: this type is marked as 'beforefieldinit'.
		static SA_AlwaysNegativeTest()
		{
			Il2CppClassPointerStore<SA_AlwaysNegativeTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_AlwaysNegativeTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AlwaysNegativeTest>.NativeClassPtr);
			SA_AlwaysNegativeTest.NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AlwaysNegativeTest>.NativeClassPtr, 100663305);
			SA_AlwaysNegativeTest.NativeMethodInfoPtr_Test_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AlwaysNegativeTest>.NativeClassPtr, 100663306);
			SA_AlwaysNegativeTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AlwaysNegativeTest>.NativeClassPtr, 100663307);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe override string Title
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158651, XrefRangeEnd = 158653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_AlwaysNegativeTest.NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002704 File Offset: 0x00000904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158653, XrefRangeEnd = 158679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Test()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_AlwaysNegativeTest.NativeMethodInfoPtr_Test_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002740 File Offset: 0x00000940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158679, XrefRangeEnd = 158680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_AlwaysNegativeTest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_AlwaysNegativeTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AlwaysNegativeTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002097 File Offset: 0x00000297
		public SA_AlwaysNegativeTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
