using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000011 RID: 17
	public class IDtdAttributeListInfo : Il2CppObjectBase
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000AD48 File Offset: 0x00008F48
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdAttributeListInfo()
		{
			Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdAttributeListInfo");
			IDtdAttributeListInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663365);
			IDtdAttributeListInfo.NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663366);
			IDtdAttributeListInfo.NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663367);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000ADAC File Offset: 0x00008FAC
		public unsafe virtual bool HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeListInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		[CallerCount(0)]
		public unsafe virtual IDtdAttributeInfo LookupAttribute(string prefix, string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeListInfo.NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000AE64 File Offset: 0x00009064
		[CallerCount(0)]
		public unsafe virtual IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeListInfo.NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000247D File Offset: 0x0000067D
		public IDtdAttributeListInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;
	}
}
