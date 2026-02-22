using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200004E RID: 78
	public class TMP_SelectionCaret : MaskableGraphic
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x00025C04 File Offset: 0x00023E04
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SelectionCaret()
		{
			Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SelectionCaret");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr);
			TMP_SelectionCaret.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr, 100664161);
			TMP_SelectionCaret.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr, 100664162);
			TMP_SelectionCaret.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr, 100664163);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00025C70 File Offset: 0x00023E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143932, XrefRangeEnd = 143934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SelectionCaret.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00025CC8 File Offset: 0x00023EC8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SelectionCaret.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00025D04 File Offset: 0x00023F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143934, XrefRangeEnd = 143935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SelectionCaret()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SelectionCaret>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SelectionCaret.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00005DDA File Offset: 0x00003FDA
		public TMP_SelectionCaret(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
