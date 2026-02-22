using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x02000358 RID: 856
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		// Token: 0x060033A3 RID: 13219 RVA: 0x000D68C8 File Offset: 0x000D4AC8
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_LabelWithIconAttribute()
		{
			Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_LabelWithIconAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr);
			SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_iconPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, "m_iconPath");
			SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_internalIconPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, "m_internalIconPath");
			SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_iconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, "m_iconType");
			SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, 100669890);
			SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr__ctor_Public_Void_IconType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, 100669891);
			SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr_get_IconPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, 100669892);
			SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr_get_InternalIconPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr, 100669893);
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000D6984 File Offset: 0x000D4B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223759, XrefRangeEnd = 223763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_LabelWithIconAttribute(string iconPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(iconPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x000D69D0 File Offset: 0x000D4BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223763, XrefRangeEnd = 223787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_LabelWithIconAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref icon;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr__ctor_Public_Void_IconType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x000D6A18 File Offset: 0x000D4C18
		public unsafe string IconPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr_get_IconPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000D6A50 File Offset: 0x000D4C50
		public unsafe string InternalIconPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_LabelWithIconAttribute.NativeMethodInfoPtr_get_InternalIconPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x0001424D File Offset: 0x0001244D
		public SA_PD_LabelWithIconAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000D6A88 File Offset: 0x000D4C88
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x00014256 File Offset: 0x00012456
		public unsafe string m_iconPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_iconPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_iconPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x000D6AB0 File Offset: 0x000D4CB0
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x00014275 File Offset: 0x00012475
		public unsafe string m_internalIconPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_internalIconPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_internalIconPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x000D6AD8 File Offset: 0x000D4CD8
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x00014294 File Offset: 0x00012494
		public unsafe SA_PD_EditorIcons.IconType m_iconType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_iconType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_LabelWithIconAttribute.NativeFieldInfoPtr_m_iconType)) = value;
			}
		}

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeFieldInfoPtr_m_iconPath;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeFieldInfoPtr_m_internalIconPath;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeFieldInfoPtr_m_iconType;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IconType_0;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeMethodInfoPtr_get_IconPath_Public_get_String_0;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalIconPath_Public_get_String_0;
	}
}
