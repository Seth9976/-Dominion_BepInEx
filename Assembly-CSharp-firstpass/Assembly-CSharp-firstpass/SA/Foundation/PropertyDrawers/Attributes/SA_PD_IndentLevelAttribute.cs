using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x02000357 RID: 855
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		// Token: 0x0600339D RID: 13213 RVA: 0x000D67B0 File Offset: 0x000D49B0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_IndentLevelAttribute()
		{
			Il2CppClassPointerStore<SA_PD_IndentLevelAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_IndentLevelAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_IndentLevelAttribute>.NativeClassPtr);
			SA_PD_IndentLevelAttribute.NativeFieldInfoPtr_m_indentLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_IndentLevelAttribute>.NativeClassPtr, "m_indentLevel");
			SA_PD_IndentLevelAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_IndentLevelAttribute>.NativeClassPtr, 100669888);
			SA_PD_IndentLevelAttribute.NativeMethodInfoPtr_get_IndentLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_IndentLevelAttribute>.NativeClassPtr, 100669889);
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000D681C File Offset: 0x000D4A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_IndentLevelAttribute(int indentLevel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_IndentLevelAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref indentLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_IndentLevelAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x000D6864 File Offset: 0x000D4A64
		public unsafe int IndentLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_IndentLevelAttribute.NativeMethodInfoPtr_get_IndentLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00014229 File Offset: 0x00012429
		public SA_PD_IndentLevelAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000D68A0 File Offset: 0x000D4AA0
		// (set) Token: 0x060033A2 RID: 13218 RVA: 0x00014232 File Offset: 0x00012432
		public unsafe int m_indentLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_IndentLevelAttribute.NativeFieldInfoPtr_m_indentLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_IndentLevelAttribute.NativeFieldInfoPtr_m_indentLevel)) = value;
			}
		}

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeFieldInfoPtr_m_indentLevel;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentLevel_Public_get_Int32_0;
	}
}
