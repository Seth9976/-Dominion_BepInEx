using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x02000359 RID: 857
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		// Token: 0x060033AF RID: 13231 RVA: 0x000D6B00 File Offset: 0x000D4D00
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_MinMaxSliderAttribute()
		{
			Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_MinMaxSliderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr);
			SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_minLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, "m_minLimit");
			SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_maxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, "m_maxLimit");
			SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, "m_color");
			SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, 100669894);
			SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr_get_MinLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, 100669895);
			SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr_get_MaxLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, 100669896);
			SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr, 100669897);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000D6BBC File Offset: 0x000D4DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223787, XrefRangeEnd = 223789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_MinMaxSliderAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLimit;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLimit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000D6C3C File Offset: 0x000D4E3C
		public unsafe float MinLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr_get_MinLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x000D6C78 File Offset: 0x000D4E78
		public unsafe float MaxLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr_get_MaxLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000D6CB4 File Offset: 0x000D4EB4
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_MinMaxSliderAttribute.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000142AF File Offset: 0x000124AF
		public SA_PD_MinMaxSliderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000D6CF0 File Offset: 0x000D4EF0
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x000142B8 File Offset: 0x000124B8
		public unsafe float m_minLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_minLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_minLimit)) = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x000D6D18 File Offset: 0x000D4F18
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x000142D3 File Offset: 0x000124D3
		public unsafe float m_maxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_maxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_maxLimit)) = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x000D6D40 File Offset: 0x000D4F40
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x000142EE File Offset: 0x000124EE
		public unsafe Color m_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_MinMaxSliderAttribute.NativeFieldInfoPtr_m_color)) = value;
			}
		}

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeFieldInfoPtr_m_minLimit;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLimit;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeFieldInfoPtr_m_color;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeMethodInfoPtr_get_MinLimit_Public_get_Single_0;

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLimit_Public_get_Single_0;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;
	}
}
