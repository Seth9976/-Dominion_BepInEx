using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000013 RID: 19
	public class IDtdDefaultAttributeInfo : Il2CppObjectBase
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000B154 File Offset: 0x00009354
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdDefaultAttributeInfo()
		{
			Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdDefaultAttributeInfo");
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663375);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663376);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663377);
			IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdDefaultAttributeInfo>.NativeClassPtr, 100663378);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000B1CC File Offset: 0x000093CC
		public unsafe virtual string DefaultValueExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000B210 File Offset: 0x00009410
		public unsafe virtual Object DefaultValueTyped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000B25C File Offset: 0x0000945C
		public unsafe virtual int ValueLineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000B2A4 File Offset: 0x000094A4
		public unsafe virtual int ValueLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdDefaultAttributeInfo.NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000248F File Offset: 0x0000068F
		public IDtdDefaultAttributeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueExpanded_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueTyped_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
