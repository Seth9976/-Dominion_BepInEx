using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000012 RID: 18
	public class IDtdAttributeInfo : Il2CppObjectBase
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x0000AEB0 File Offset: 0x000090B0
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdAttributeInfo()
		{
			Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdAttributeInfo");
			IDtdAttributeInfo.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663368);
			IDtdAttributeInfo.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663369);
			IDtdAttributeInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663370);
			IDtdAttributeInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663371);
			IDtdAttributeInfo.NativeMethodInfoPtr_get_IsNonCDataType_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663372);
			IDtdAttributeInfo.NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663373);
			IDtdAttributeInfo.NativeMethodInfoPtr_get_IsXmlAttribute_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeInfo>.NativeClassPtr, 100663374);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000AF64 File Offset: 0x00009164
		public unsafe virtual string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000AFA8 File Offset: 0x000091A8
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000AFEC File Offset: 0x000091EC
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000B034 File Offset: 0x00009234
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000B07C File Offset: 0x0000927C
		public unsafe virtual bool IsNonCDataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_IsNonCDataType_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000B0C4 File Offset: 0x000092C4
		public unsafe virtual bool IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000B10C File Offset: 0x0000930C
		public unsafe virtual bool IsXmlAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdAttributeInfo.NativeMethodInfoPtr_get_IsXmlAttribute_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002486 File Offset: 0x00000686
		public IDtdAttributeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNonCDataType_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlAttribute_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
