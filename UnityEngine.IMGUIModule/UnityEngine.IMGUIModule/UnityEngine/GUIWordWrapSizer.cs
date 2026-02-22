using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x00012388 File Offset: 0x00010588
		// Note: this type is marked as 'beforefieldinit'.
		static GUIWordWrapSizer()
		{
			Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIWordWrapSizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr);
			GUIWordWrapSizer.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_Content");
			GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_ForcedMinHeight");
			GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_ForcedMaxHeight");
			GUIWordWrapSizer.NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663675);
			GUIWordWrapSizer.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663676);
			GUIWordWrapSizer.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663677);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00012430 File Offset: 0x00010630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87879, XrefRangeEnd = 87890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIWordWrapSizer(GUIStyle style, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIWordWrapSizer.NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000124A0 File Offset: 0x000106A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87890, XrefRangeEnd = 87894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIWordWrapSizer.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000124D4 File Offset: 0x000106D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87894, XrefRangeEnd = 87897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIWordWrapSizer.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003EAB File Offset: 0x000020AB
		public GUIWordWrapSizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00012508 File Offset: 0x00010708
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00003EB4 File Offset: 0x000020B4
		public unsafe GUIContent m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00012538 File Offset: 0x00010738
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003ED3 File Offset: 0x000020D3
		public unsafe float m_ForcedMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMinHeight)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00012560 File Offset: 0x00010760
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003EEE File Offset: 0x000020EE
		public unsafe float m_ForcedMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIWordWrapSizer.NativeFieldInfoPtr_m_ForcedMaxHeight)) = value;
			}
		}

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedMinHeight;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcedMaxHeight;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;
	}
}
