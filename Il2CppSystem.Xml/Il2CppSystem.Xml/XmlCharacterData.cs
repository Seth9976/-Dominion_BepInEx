using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000029 RID: 41
	public class XmlCharacterData : XmlLinkedNode
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00017070 File Offset: 0x00015270
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCharacterData()
		{
			Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCharacterData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr);
			XmlCharacterData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, "data");
			XmlCharacterData.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663882);
			XmlCharacterData.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663883);
			XmlCharacterData.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663884);
			XmlCharacterData.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663885);
			XmlCharacterData.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663886);
			XmlCharacterData.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663887);
			XmlCharacterData.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663888);
			XmlCharacterData.NativeMethodInfoPtr_CheckOnData_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr, 100663889);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00017154 File Offset: 0x00015354
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14889, RefRangeEnd = 14893, XrefRangeStart = 14889, XrefRangeEnd = 14893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCharacterData(string data, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCharacterData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharacterData.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000171B4 File Offset: 0x000153B4
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000171F8 File Offset: 0x000153F8
		public unsafe override string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCharacterData.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCharacterData.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00017248 File Offset: 0x00015448
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0001728C File Offset: 0x0001548C
		public unsafe override string InnerText
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14894, RefRangeEnd = 14910, XrefRangeStart = 14894, XrefRangeEnd = 14894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCharacterData.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCharacterData.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000172DC File Offset: 0x000154DC
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00017320 File Offset: 0x00015520
		public unsafe virtual string Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14910, XrefRangeEnd = 14912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCharacterData.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlCharacterData.NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00017370 File Offset: 0x00015570
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14920, RefRangeEnd = 14924, XrefRangeStart = 14912, XrefRangeEnd = 14920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckOnData(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCharacterData.NativeMethodInfoPtr_CheckOnData_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000325E File Offset: 0x0000145E
		public XmlCharacterData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000173C0 File Offset: 0x000155C0
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00003267 File Offset: 0x00001467
		public unsafe string data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharacterData.NativeFieldInfoPtr_data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCharacterData.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_XmlDocument_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_String_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_CheckOnData_Internal_Boolean_String_0;
	}
}
