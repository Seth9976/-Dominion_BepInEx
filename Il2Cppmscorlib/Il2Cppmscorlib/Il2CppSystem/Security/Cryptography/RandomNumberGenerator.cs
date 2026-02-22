using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F4 RID: 756
	public class RandomNumberGenerator : Object
	{
		// Token: 0x0600316C RID: 12652 RVA: 0x000F59E8 File Offset: 0x000F3BE8
		// Note: this type is marked as 'beforefieldinit'.
		static RandomNumberGenerator()
		{
			Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RandomNumberGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr);
			RandomNumberGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671048);
			RandomNumberGenerator.NativeMethodInfoPtr_Create_Public_Static_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671049);
			RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671050);
			RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671051);
			RandomNumberGenerator.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671052);
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000F5A7C File Offset: 0x000F3C7C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomNumberGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomNumberGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x000F5AB8 File Offset: 0x000F3CB8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 339915, RefRangeEnd = 339936, XrefRangeStart = 339906, XrefRangeEnd = 339915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RandomNumberGenerator Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomNumberGenerator.NativeMethodInfoPtr_Create_Public_Static_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x000F5AEC File Offset: 0x000F3CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339936, XrefRangeEnd = 339940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x000F5B20 File Offset: 0x000F3D20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x000F5B6C File Offset: 0x000F3D6C
		[CallerCount(0)]
		public unsafe virtual void GetBytes(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomNumberGenerator.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x00011800 File Offset: 0x0000FA00
		public RandomNumberGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RandomNumberGenerator_0;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0;
	}
}
