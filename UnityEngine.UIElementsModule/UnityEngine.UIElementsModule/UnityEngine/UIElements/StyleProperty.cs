using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BA RID: 186
	[Serializable]
	public class StyleProperty : Object
	{
		// Token: 0x06000ABB RID: 2747 RVA: 0x0002D7C8 File Offset: 0x0002B9C8
		// Note: this type is marked as 'beforefieldinit'.
		static StyleProperty()
		{
			Il2CppClassPointerStore<StyleProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr);
			StyleProperty.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "m_Name");
			StyleProperty.NativeFieldInfoPtr_m_Line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "m_Line");
			StyleProperty.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "m_Values");
			StyleProperty.NativeFieldInfoPtr_isCustomProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "isCustomProperty");
			StyleProperty.NativeFieldInfoPtr_requireVariableResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, "requireVariableResolve");
			StyleProperty.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, 100664209);
			StyleProperty.NativeMethodInfoPtr_get_values_Public_get_Il2CppStructArray_1_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, 100664210);
			StyleProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr, 100664211);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002D898 File Offset: 0x0002BA98
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006D6C File Offset: 0x00004F6C
		public unsafe string name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleProperty.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0002D8D0 File Offset: 0x0002BAD0
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00006D80 File Offset: 0x00004F80
		public unsafe Il2CppStructArray<StyleValueHandle> values
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleProperty.NativeMethodInfoPtr_get_values_Public_get_Il2CppStructArray_1_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr3) : null;
			}
			set
			{
				this.m_Values = value;
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0002D910 File Offset: 0x0002BB10
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public StyleProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002D94C File Offset: 0x0002BB4C
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00006CDD File Offset: 0x00004EDD
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002D974 File Offset: 0x0002BB74
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00006CFC File Offset: 0x00004EFC
		public unsafe int m_Line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Line)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002D99C File Offset: 0x0002BB9C
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00006D17 File Offset: 0x00004F17
		public unsafe Il2CppStructArray<StyleValueHandle> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<StyleValueHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002D9CC File Offset: 0x0002BBCC
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00006D36 File Offset: 0x00004F36
		public unsafe bool isCustomProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_isCustomProperty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_isCustomProperty)) = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002D9F4 File Offset: 0x0002BBF4
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00006D51 File Offset: 0x00004F51
		public unsafe bool requireVariableResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_requireVariableResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleProperty.NativeFieldInfoPtr_requireVariableResolve)) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0002DA1C File Offset: 0x0002BC1C
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00006D76 File Offset: 0x00004F76
		public int line
		{
			get
			{
				return this.m_Line;
			}
			set
			{
				this.m_Line = value;
			}
		}

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_m_Line;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr_isCustomProperty;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_requireVariableResolve;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_get_values_Public_get_Il2CppStructArray_1_StyleValueHandle_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
