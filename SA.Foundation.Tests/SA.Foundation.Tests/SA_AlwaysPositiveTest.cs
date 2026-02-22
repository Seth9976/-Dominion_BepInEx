using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace SA.Foundation.Tests
{
	// Token: 0x02000004 RID: 4
	public class SA_AlwaysPositiveTest : SA_BaseTest
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000277C File Offset: 0x0000097C
		// Note: this type is marked as 'beforefieldinit'.
		static SA_AlwaysPositiveTest()
		{
			Il2CppClassPointerStore<SA_AlwaysPositiveTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_AlwaysPositiveTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AlwaysPositiveTest>.NativeClassPtr);
			SA_AlwaysPositiveTest.NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AlwaysPositiveTest>.NativeClassPtr, 100663308);
			SA_AlwaysPositiveTest.NativeMethodInfoPtr_Test_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AlwaysPositiveTest>.NativeClassPtr, 100663309);
			SA_AlwaysPositiveTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AlwaysPositiveTest>.NativeClassPtr, 100663310);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000027E8 File Offset: 0x000009E8
		public unsafe override string Title
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158680, XrefRangeEnd = 158682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_AlwaysPositiveTest.NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000282C File Offset: 0x00000A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158682, XrefRangeEnd = 158687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Test()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_AlwaysPositiveTest.NativeMethodInfoPtr_Test_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002868 File Offset: 0x00000A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_AlwaysPositiveTest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_AlwaysPositiveTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AlwaysPositiveTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020A0 File Offset: 0x000002A0
		public SA_AlwaysPositiveTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Void_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
