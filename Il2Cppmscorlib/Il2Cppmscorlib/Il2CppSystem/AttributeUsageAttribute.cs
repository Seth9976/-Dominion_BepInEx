using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200007E RID: 126
	[Serializable]
	public sealed class AttributeUsageAttribute : Attribute
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x000437C4 File Offset: 0x000419C4
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeUsageAttribute()
		{
			Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AttributeUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr);
			AttributeUsageAttribute.NativeFieldInfoPtr_m_attributeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "m_attributeTarget");
			AttributeUsageAttribute.NativeFieldInfoPtr_m_allowMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "m_allowMultiple");
			AttributeUsageAttribute.NativeFieldInfoPtr_m_inherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "m_inherited");
			AttributeUsageAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "Default");
			AttributeUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664460);
			AttributeUsageAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664461);
			AttributeUsageAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664462);
			AttributeUsageAttribute.NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664463);
			AttributeUsageAttribute.NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664464);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000438A8 File Offset: 0x00041AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276449, XrefRangeEnd = 276450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeUsageAttribute(AttributeTargets validOn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x000438F0 File Offset: 0x00041AF0
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x0004392C File Offset: 0x00041B2C
		public unsafe bool AllowMultiple
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0004396C File Offset: 0x00041B6C
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x000439A8 File Offset: 0x00041BA8
		public unsafe bool Inherited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000045BA File Offset: 0x000027BA
		public AttributeUsageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000439E8 File Offset: 0x00041BE8
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x000045C3 File Offset: 0x000027C3
		public unsafe AttributeTargets m_attributeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_attributeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_attributeTarget)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00043A10 File Offset: 0x00041C10
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x000045DE File Offset: 0x000027DE
		public unsafe bool m_allowMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_allowMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_allowMultiple)) = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00043A38 File Offset: 0x00041C38
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000045F9 File Offset: 0x000027F9
		public unsafe bool m_inherited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_inherited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_inherited)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00043A60 File Offset: 0x00041C60
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00004614 File Offset: 0x00002814
		public unsafe static AttributeUsageAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeUsageAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeUsageAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_m_attributeTarget;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_m_allowMultiple;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_m_inherited;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0;
	}
}
