using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000022 RID: 34
	[StructLayout(2)]
	public struct HighlightState
	{
		// Token: 0x06000320 RID: 800 RVA: 0x000140A8 File Offset: 0x000122A8
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightState()
		{
			Il2CppClassPointerStore<HighlightState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "HighlightState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightState>.NativeClassPtr);
			HighlightState.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, "color");
			HighlightState.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, "padding");
			HighlightState.NativeMethodInfoPtr__ctor_Public_Void_Color32_TMP_Offset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663599);
			HighlightState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663600);
			HighlightState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663601);
			HighlightState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663602);
			HighlightState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663603);
			HighlightState.NativeMethodInfoPtr_Equals_Public_Boolean_HighlightState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, 100663604);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00014178 File Offset: 0x00012378
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 137636, RefRangeEnd = 137642, XrefRangeStart = 137636, XrefRangeEnd = 137636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightState(Color32 color, TMP_Offset padding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr__ctor_Public_Void_Color32_TMP_Offset_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000141B8 File Offset: 0x000123B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137642, XrefRangeEnd = 137644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HighlightState lhs, HighlightState rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00014204 File Offset: 0x00012404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137646, RefRangeEnd = 137648, XrefRangeStart = 137644, XrefRangeEnd = 137646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HighlightState lhs, HighlightState rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00014250 File Offset: 0x00012450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137648, XrefRangeEnd = 137652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00014280 File Offset: 0x00012480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137652, XrefRangeEnd = 137656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000142C4 File Offset: 0x000124C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137656, XrefRangeEnd = 137662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HighlightState other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightState.NativeMethodInfoPtr_Equals_Public_Boolean_HighlightState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003821 File Offset: 0x00001A21
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HighlightState>.NativeClassPtr, ref this));
		}

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_TMP_Offset_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HighlightState_HighlightState_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HighlightState_HighlightState_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_HighlightState_0;

		// Token: 0x04000266 RID: 614
		[FieldOffset(0)]
		public Color32 color;

		// Token: 0x04000267 RID: 615
		[FieldOffset(4)]
		public TMP_Offset padding;
	}
}
