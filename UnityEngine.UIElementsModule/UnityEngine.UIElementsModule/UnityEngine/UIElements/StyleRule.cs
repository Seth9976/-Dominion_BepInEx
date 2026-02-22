using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BB RID: 187
	[Serializable]
	public class StyleRule : Object
	{
		// Token: 0x06000ACE RID: 2766 RVA: 0x0002DA34 File Offset: 0x0002BC34
		// Note: this type is marked as 'beforefieldinit'.
		static StyleRule()
		{
			Il2CppClassPointerStore<StyleRule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleRule>.NativeClassPtr);
			StyleRule.NativeFieldInfoPtr_m_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, "m_Properties");
			StyleRule.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, "line");
			StyleRule.NativeFieldInfoPtr_customPropertiesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, "customPropertiesCount");
			StyleRule.NativeMethodInfoPtr_get_properties_Public_get_Il2CppReferenceArray_1_StyleProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, 100664212);
			StyleRule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleRule>.NativeClassPtr, 100664213);
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0002DAC8 File Offset: 0x0002BCC8
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00006DE8 File Offset: 0x00004FE8
		public unsafe Il2CppReferenceArray<StyleProperty> properties
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRule.NativeMethodInfoPtr_get_properties_Public_get_Il2CppReferenceArray_1_StyleProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr3) : null;
			}
			set
			{
				this.m_Properties = value;
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002DB08 File Offset: 0x0002BD08
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleRule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleRule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00006D8A File Offset: 0x00004F8A
		public StyleRule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002DB44 File Offset: 0x0002BD44
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00006D93 File Offset: 0x00004F93
		public unsafe Il2CppReferenceArray<StyleProperty> m_Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_m_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_m_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0002DB74 File Offset: 0x0002BD74
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00006DB2 File Offset: 0x00004FB2
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00006DCD File Offset: 0x00004FCD
		public unsafe int customPropertiesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_customPropertiesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleRule.NativeFieldInfoPtr_customPropertiesCount)) = value;
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_Properties;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_customPropertiesCount;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_get_properties_Public_get_Il2CppReferenceArray_1_StyleProperty_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
