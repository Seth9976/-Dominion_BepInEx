using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000089 RID: 137
	public class GoogleSkuTypeEnum : Object
	{
		// Token: 0x06000576 RID: 1398 RVA: 0x00017CC8 File Offset: 0x00015EC8
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleSkuTypeEnum()
		{
			Il2CppClassPointerStore<GoogleSkuTypeEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GoogleSkuTypeEnum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleSkuTypeEnum>.NativeClassPtr);
			GoogleSkuTypeEnum.NativeMethodInfoPtr_GetSkuTypeJavaObject_Private_Static_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleSkuTypeEnum>.NativeClassPtr, 100663961);
			GoogleSkuTypeEnum.NativeMethodInfoPtr_InApp_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleSkuTypeEnum>.NativeClassPtr, 100663962);
			GoogleSkuTypeEnum.NativeMethodInfoPtr_Sub_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleSkuTypeEnum>.NativeClassPtr, 100663963);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00017D34 File Offset: 0x00015F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157359, XrefRangeEnd = 157365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject GetSkuTypeJavaObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleSkuTypeEnum.NativeMethodInfoPtr_GetSkuTypeJavaObject_Private_Static_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00017D68 File Offset: 0x00015F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157377, RefRangeEnd = 157378, XrefRangeStart = 157365, XrefRangeEnd = 157377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InApp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleSkuTypeEnum.NativeMethodInfoPtr_InApp_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00017D94 File Offset: 0x00015F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157378, XrefRangeEnd = 157390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Sub()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleSkuTypeEnum.NativeMethodInfoPtr_Sub_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00004C54 File Offset: 0x00002E54
		public GoogleSkuTypeEnum(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_GetSkuTypeJavaObject_Private_Static_AndroidJavaObject_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_InApp_Internal_Static_String_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_Sub_Internal_Static_String_0;
	}
}
