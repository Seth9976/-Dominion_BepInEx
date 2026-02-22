using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D8 RID: 216
	public class IXmlSchemaInfo : Il2CppObjectBase
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x0003F0BC File Offset: 0x0003D2BC
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlSchemaInfo()
		{
			Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "IXmlSchemaInfo");
			IXmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665225);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665226);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665227);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665228);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665229);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665230);
			IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSchemaInfo>.NativeClassPtr, 100665231);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0003F170 File Offset: 0x0003D370
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		public unsafe virtual bool IsDefault
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0003F200 File Offset: 0x0003D400
		public unsafe virtual bool IsNil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0003F248 File Offset: 0x0003D448
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0003F294 File Offset: 0x0003D494
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x0003F2E0 File Offset: 0x0003D4E0
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0003F32C File Offset: 0x0003D52C
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSchemaInfo.NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x000063AD File Offset: 0x000045AD
		public IXmlSchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Abstract_Virtual_New_get_XmlSchemaValidity_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Abstract_Virtual_New_get_XmlSchemaSimpleType_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Abstract_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Abstract_Virtual_New_get_XmlSchemaElement_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Abstract_Virtual_New_get_XmlSchemaAttribute_0;
	}
}
