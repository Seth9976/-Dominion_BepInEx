using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace SA.Foundation.Tests
{
	// Token: 0x02000005 RID: 5
	public class SA_ThrowExceptionTest : SA_BaseTest
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000028A4 File Offset: 0x00000AA4
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ThrowExceptionTest()
		{
			Il2CppClassPointerStore<SA_ThrowExceptionTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_ThrowExceptionTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ThrowExceptionTest>.NativeClassPtr);
			SA_ThrowExceptionTest.NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ThrowExceptionTest>.NativeClassPtr, 100663311);
			SA_ThrowExceptionTest.NativeMethodInfoPtr_Test_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ThrowExceptionTest>.NativeClassPtr, 100663312);
			SA_ThrowExceptionTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ThrowExceptionTest>.NativeClassPtr, 100663313);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002910 File Offset: 0x00000B10
		public unsafe override string Title
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158687, XrefRangeEnd = 158689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_ThrowExceptionTest.NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002954 File Offset: 0x00000B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158689, XrefRangeEnd = 158694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Test()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_ThrowExceptionTest.NativeMethodInfoPtr_Test_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002990 File Offset: 0x00000B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ThrowExceptionTest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ThrowExceptionTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ThrowExceptionTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A9 File Offset: 0x000002A9
		public SA_ThrowExceptionTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_Virtual_get_String_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Virtual_Void_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
