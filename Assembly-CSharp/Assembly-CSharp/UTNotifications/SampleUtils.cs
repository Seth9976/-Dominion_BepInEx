using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UTNotifications
{
	// Token: 0x020000E8 RID: 232
	public static class SampleUtils : global::Il2CppSystem.Object
	{
		// Token: 0x06001C6A RID: 7274 RVA: 0x0006F038 File Offset: 0x0006D238
		// Note: this type is marked as 'beforefieldinit'.
		static SampleUtils()
		{
			Il2CppClassPointerStore<SampleUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "SampleUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SampleUtils>.NativeClassPtr);
			SampleUtils.NativeMethodInfoPtr_UniqueName_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleUtils>.NativeClassPtr, 100665523);
			SampleUtils.NativeMethodInfoPtr_GenerateDeviceUniqueIdentifier_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleUtils>.NativeClassPtr, 100665524);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0006F090 File Offset: 0x0006D290
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253663, RefRangeEnd = 253666, XrefRangeStart = 253652, XrefRangeEnd = 253663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UniqueName(Transform transform)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleUtils.NativeMethodInfoPtr_UniqueName_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0006F0CC File Offset: 0x0006D2CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156598, RefRangeEnd = 156599, XrefRangeStart = 156598, XrefRangeEnd = 156599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateDeviceUniqueIdentifier()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleUtils.NativeMethodInfoPtr_GenerateDeviceUniqueIdentifier_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00012433 File Offset: 0x00010633
		public SampleUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_UniqueName_Public_Static_String_Transform_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_GenerateDeviceUniqueIdentifier_Public_Static_String_0;
	}
}
