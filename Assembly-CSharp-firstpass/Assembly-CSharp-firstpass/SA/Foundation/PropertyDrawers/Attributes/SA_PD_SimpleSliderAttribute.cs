using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x0200035A RID: 858
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		// Token: 0x060033BB RID: 13243 RVA: 0x000D6D68 File Offset: 0x000D4F68
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_SimpleSliderAttribute()
		{
			Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_SimpleSliderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr);
			SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_minLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, "m_minLimit");
			SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_maxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, "m_maxLimit");
			SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, "m_color");
			SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, 100669898);
			SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr_get_MinLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, 100669899);
			SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr_get_MaxLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, 100669900);
			SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr, 100669901);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000D6E24 File Offset: 0x000D5024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_SimpleSliderAttribute>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x000D6EA4 File Offset: 0x000D50A4
		public unsafe float MinLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr_get_MinLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x000D6EE0 File Offset: 0x000D50E0
		public unsafe float MaxLimit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr_get_MaxLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x000D6F1C File Offset: 0x000D511C
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_SimpleSliderAttribute.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00014309 File Offset: 0x00012509
		public SA_PD_SimpleSliderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000D6F58 File Offset: 0x000D5158
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x00014312 File Offset: 0x00012512
		public unsafe float m_minLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_minLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_minLimit)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x000D6F80 File Offset: 0x000D5180
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x0001432D File Offset: 0x0001252D
		public unsafe float m_maxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_maxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_maxLimit)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x000D6FA8 File Offset: 0x000D51A8
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x00014348 File Offset: 0x00012548
		public unsafe Color m_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_SimpleSliderAttribute.NativeFieldInfoPtr_m_color)) = value;
			}
		}

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeFieldInfoPtr_m_minLimit;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeFieldInfoPtr_m_maxLimit;

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeFieldInfoPtr_m_color;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeMethodInfoPtr_get_MinLimit_Public_get_Single_0;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLimit_Public_get_Single_0;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;
	}
}
