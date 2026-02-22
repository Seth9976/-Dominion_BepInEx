using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200002E RID: 46
	public static class MultipleDisplayUtilities : Object
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x0001AF00 File Offset: 0x00019100
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleDisplayUtilities()
		{
			Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MultipleDisplayUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr);
			MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664057);
			MultipleDisplayUtilities.NativeMethodInfoPtr_GetMousePositionRelativeToMainDisplayResolution_Public_Static_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleDisplayUtilities>.NativeClassPtr, 100664058);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0001AF58 File Offset: 0x00019158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116428, RefRangeEnd = 116431, XrefRangeStart = 116423, XrefRangeEnd = 116428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0001AFA8 File Offset: 0x000191A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116454, RefRangeEnd = 116455, XrefRangeStart = 116431, XrefRangeEnd = 116454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetMousePositionRelativeToMainDisplayResolution()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleDisplayUtilities.NativeMethodInfoPtr_GetMousePositionRelativeToMainDisplayResolution_Public_Static_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00003C25 File Offset: 0x00001E25
		public MultipleDisplayUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeMousePositionForDrag_Public_Static_Boolean_PointerEventData_byref_Vector2_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePositionRelativeToMainDisplayResolution_Public_Static_Vector2_0;
	}
}
