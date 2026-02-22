using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public sealed class GUILayoutOption : Object
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000B274 File Offset: 0x00009474
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutOption()
		{
			Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr);
			GUILayoutOption.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, "type");
			GUILayoutOption.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, "value");
			GUILayoutOption.NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr, 100663458);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 50515, RefRangeEnd = 50526, XrefRangeStart = 50515, XrefRangeEnd = 50526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutOption(GUILayoutOption.Type type, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutOption>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutOption.NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002F8A File Offset: 0x0000118A
		public GUILayoutOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000B33C File Offset: 0x0000953C
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002F93 File Offset: 0x00001193
		public unsafe GUILayoutOption.Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000B364 File Offset: 0x00009564
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002FAE File Offset: 0x000011AE
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutOption.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Object_0;

		// Token: 0x02000067 RID: 103
		public enum Type
		{
			// Token: 0x04000351 RID: 849
			fixedWidth,
			// Token: 0x04000352 RID: 850
			fixedHeight,
			// Token: 0x04000353 RID: 851
			minWidth,
			// Token: 0x04000354 RID: 852
			maxWidth,
			// Token: 0x04000355 RID: 853
			minHeight,
			// Token: 0x04000356 RID: 854
			maxHeight,
			// Token: 0x04000357 RID: 855
			stretchWidth,
			// Token: 0x04000358 RID: 856
			stretchHeight,
			// Token: 0x04000359 RID: 857
			alignStart,
			// Token: 0x0400035A RID: 858
			alignMiddle,
			// Token: 0x0400035B RID: 859
			alignEnd,
			// Token: 0x0400035C RID: 860
			alignJustify,
			// Token: 0x0400035D RID: 861
			equalSize,
			// Token: 0x0400035E RID: 862
			spacing
		}
	}
}
