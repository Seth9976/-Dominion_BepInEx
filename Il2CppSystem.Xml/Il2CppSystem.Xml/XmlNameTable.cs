using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000062 RID: 98
	public class XmlNameTable : Object
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x0002B470 File Offset: 0x00029670
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNameTable()
		{
			Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNameTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr);
			XmlNameTable.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr, 100664599);
			XmlNameTable.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr, 100664600);
			XmlNameTable.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr, 100664601);
			XmlNameTable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr, 100664602);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002B4F0 File Offset: 0x000296F0
		[CallerCount(0)]
		public unsafe virtual string Get(string array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNameTable.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002B544 File Offset: 0x00029744
		[CallerCount(0)]
		public unsafe virtual string Add(Il2CppStructArray<char> array, int offset, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNameTable.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_String_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0002B5B4 File Offset: 0x000297B4
		[CallerCount(0)]
		public unsafe virtual string Add(string array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNameTable.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0002B608 File Offset: 0x00029808
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNameTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNameTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNameTable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000047E1 File Offset: 0x000029E1
		public XmlNameTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
