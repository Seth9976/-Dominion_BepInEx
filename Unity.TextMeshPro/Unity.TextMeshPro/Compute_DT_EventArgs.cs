using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000010 RID: 16
	public class Compute_DT_EventArgs : global::Il2CppSystem.Object
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00011054 File Offset: 0x0000F254
		// Note: this type is marked as 'beforefieldinit'.
		static Compute_DT_EventArgs()
		{
			Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "Compute_DT_EventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr);
			Compute_DT_EventArgs.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "EventType");
			Compute_DT_EventArgs.NativeFieldInfoPtr_ProgressPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "ProgressPercentage");
			Compute_DT_EventArgs.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, "Colors");
			Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, 100663537);
			Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr, 100663538);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137334, XrefRangeEnd = 137335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00011140 File Offset: 0x0000F340
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 50515, RefRangeEnd = 50526, XrefRangeStart = 50515, XrefRangeEnd = 50526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Il2CppStructArray<Color> colors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Compute_DT_EventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Compute_DT_EventArgs.NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002C57 File Offset: 0x00000E57
		public Compute_DT_EventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0001119C File Offset: 0x0000F39C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002C60 File Offset: 0x00000E60
		public unsafe Compute_DistanceTransform_EventTypes EventType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_EventType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_EventType)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000111C4 File Offset: 0x0000F3C4
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002C7B File Offset: 0x00000E7B
		public unsafe float ProgressPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_ProgressPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_ProgressPercentage)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000111EC File Offset: 0x0000F3EC
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002C96 File Offset: 0x00000E96
		public unsafe Il2CppStructArray<Color> Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Compute_DT_EventArgs.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_ProgressPercentage;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_Colors;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Single_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Compute_DistanceTransform_EventTypes_Il2CppStructArray_1_Color_0;
	}
}
