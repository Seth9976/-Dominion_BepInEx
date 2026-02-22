using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000015 RID: 21
	public class IDtdParser : Il2CppObjectBase
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0000B74C File Offset: 0x0000994C
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParser()
		{
			Il2CppClassPointerStore<IDtdParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParser");
			IDtdParser.NativeMethodInfoPtr_ParseInternalDtd_Public_Abstract_Virtual_New_IDtdInfo_IDtdParserAdapter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParser>.NativeClassPtr, 100663391);
			IDtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Public_Abstract_Virtual_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParser>.NativeClassPtr, 100663392);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000B79C File Offset: 0x0000999C
		[CallerCount(0)]
		public unsafe virtual IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveInternalSubset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParser.NativeMethodInfoPtr_ParseInternalDtd_Public_Abstract_Virtual_New_IDtdInfo_IDtdParserAdapter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000B808 File Offset: 0x00009A08
		[CallerCount(0)]
		public unsafe virtual IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Public_Abstract_Virtual_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000024A1 File Offset: 0x000006A1
		public IDtdParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_ParseInternalDtd_Public_Abstract_Virtual_New_IDtdInfo_IDtdParserAdapter_Boolean_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_ParseFreeFloatingDtd_Public_Abstract_Virtual_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0;
	}
}
