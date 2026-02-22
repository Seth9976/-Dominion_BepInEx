using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000010 RID: 16
	public class IDtdInfo : Il2CppObjectBase
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000AABC File Offset: 0x00008CBC
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdInfo()
		{
			Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdInfo");
			IDtdInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663359);
			IDtdInfo.NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663360);
			IDtdInfo.NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663361);
			IDtdInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663362);
			IDtdInfo.NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663363);
			IDtdInfo.NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdInfo>.NativeClassPtr, 100663364);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000AB5C File Offset: 0x00008D5C
		public unsafe virtual XmlQualifiedName Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		public unsafe virtual string InternalDtdSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000ABEC File Offset: 0x00008DEC
		public unsafe virtual bool HasDefaultAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000AC34 File Offset: 0x00008E34
		public unsafe virtual bool HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000AC7C File Offset: 0x00008E7C
		[CallerCount(0)]
		public unsafe virtual IDtdAttributeListInfo LookupAttributeList(string prefix, string localName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeListInfo>(intPtr3) : null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[CallerCount(0)]
		public unsafe virtual IDtdEntityInfo LookupEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdInfo.NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002474 File Offset: 0x00000674
		public IDtdInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_XmlQualifiedName_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDtdSubset_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_LookupAttributeList_Public_Abstract_Virtual_New_IDtdAttributeListInfo_String_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_LookupEntity_Public_Abstract_Virtual_New_IDtdEntityInfo_String_0;
	}
}
