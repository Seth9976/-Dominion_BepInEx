using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000099 RID: 153
	public class Datatype_yearMonthDuration : Datatype_duration
	{
		// Token: 0x06000B09 RID: 2825 RVA: 0x000365D8 File Offset: 0x000347D8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_yearMonthDuration()
		{
			Il2CppClassPointerStore<Datatype_yearMonthDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_yearMonthDuration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_yearMonthDuration>.NativeClassPtr);
			Datatype_yearMonthDuration.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonthDuration>.NativeClassPtr, 100664926);
			Datatype_yearMonthDuration.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonthDuration>.NativeClassPtr, 100664927);
			Datatype_yearMonthDuration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonthDuration>.NativeClassPtr, 100664928);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00036644 File Offset: 0x00034844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22724, XrefRangeEnd = 22739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_yearMonthDuration.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000366E8 File Offset: 0x000348E8
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_yearMonthDuration.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00036730 File Offset: 0x00034930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22739, XrefRangeEnd = 22743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_yearMonthDuration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_yearMonthDuration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_yearMonthDuration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00005C5D File Offset: 0x00003E5D
		public Datatype_yearMonthDuration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
