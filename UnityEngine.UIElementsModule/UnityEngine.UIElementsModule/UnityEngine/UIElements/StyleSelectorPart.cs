using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BD RID: 189
	[Serializable]
	public sealed class StyleSelectorPart : ValueType
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002DE00 File Offset: 0x0002C000
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSelectorPart()
		{
			Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleSelectorPart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr);
			StyleSelectorPart.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, "m_Value");
			StyleSelectorPart.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, "m_Type");
			StyleSelectorPart.NativeFieldInfoPtr_tempData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, "tempData");
			StyleSelectorPart.NativeMethodInfoPtr_get_value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100664220);
			StyleSelectorPart.NativeMethodInfoPtr_get_type_Public_get_StyleSelectorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100664221);
			StyleSelectorPart.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr, 100664222);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x00006EF3 File Offset: 0x000050F3
		public unsafe string value
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_get_value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00006EFD File Offset: 0x000050FD
		public unsafe StyleSelectorType type
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_get_type_Public_get_StyleSelectorType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0002DF28 File Offset: 0x0002C128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96955, RefRangeEnd = 96956, XrefRangeStart = 96944, XrefRangeEnd = 96955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSelectorPart.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00006E7F File Offset: 0x0000507F
		public StyleSelectorPart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00006E88 File Offset: 0x00005088
		public StyleSelectorPart()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSelectorPart>.NativeClassPtr))
		{
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0002DF64 File Offset: 0x0002C164
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00006E9A File Offset: 0x0000509A
		public unsafe string m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0002DF8C File Offset: 0x0002C18C
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00006EB9 File Offset: 0x000050B9
		public unsafe StyleSelectorType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0002DFB4 File Offset: 0x0002C1B4
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00006ED4 File Offset: 0x000050D4
		public unsafe Object tempData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_tempData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSelectorPart.NativeFieldInfoPtr_tempData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0002DFE4 File Offset: 0x0002C1E4
		public static StyleSelectorPart CreateClass(string className)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Class;
			styleSelectorPart.m_Value = className;
			return styleSelectorPart;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0002E010 File Offset: 0x0002C210
		public static StyleSelectorPart CreatePseudoClass(string className)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.PseudoClass;
			styleSelectorPart.m_Value = className;
			return styleSelectorPart;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0002E03C File Offset: 0x0002C23C
		public static StyleSelectorPart CreateId(string Id)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.ID;
			styleSelectorPart.m_Value = Id;
			return styleSelectorPart;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002E068 File Offset: 0x0002C268
		public static StyleSelectorPart CreateType(Type t)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Type;
			styleSelectorPart.m_Value = t.Name;
			return styleSelectorPart;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002E098 File Offset: 0x0002C298
		public static StyleSelectorPart CreateType(string typeName)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Type;
			styleSelectorPart.m_Value = typeName;
			return styleSelectorPart;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		public static StyleSelectorPart CreatePredicate(Object predicate)
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Predicate;
			styleSelectorPart.tempData = predicate;
			return styleSelectorPart;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002E0F0 File Offset: 0x0002C2F0
		public static StyleSelectorPart CreateWildCard()
		{
			StyleSelectorPart styleSelectorPart = null;
			styleSelectorPart.m_Type = StyleSelectorType.Wildcard;
			return styleSelectorPart;
		}

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr_tempData;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_String_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_StyleSelectorType_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
