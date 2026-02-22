using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000014 RID: 20
	public class IDtdEntityInfo : Il2CppObjectBase
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0000B2EC File Offset: 0x000094EC
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdEntityInfo()
		{
			Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdEntityInfo");
			IDtdEntityInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663379);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsExternal_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663380);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663381);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsUnparsedEntity_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663382);
			IDtdEntityInfo.NativeMethodInfoPtr_get_IsParameterEntity_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663383);
			IDtdEntityInfo.NativeMethodInfoPtr_get_BaseUriString_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663384);
			IDtdEntityInfo.NativeMethodInfoPtr_get_DeclaredUriString_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663385);
			IDtdEntityInfo.NativeMethodInfoPtr_get_SystemId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663386);
			IDtdEntityInfo.NativeMethodInfoPtr_get_PublicId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663387);
			IDtdEntityInfo.NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663388);
			IDtdEntityInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663389);
			IDtdEntityInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdEntityInfo>.NativeClassPtr, 100663390);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000B404 File Offset: 0x00009604
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000B448 File Offset: 0x00009648
		public unsafe virtual bool IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsExternal_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000B490 File Offset: 0x00009690
		public unsafe virtual bool IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000B4D8 File Offset: 0x000096D8
		public unsafe virtual bool IsUnparsedEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsUnparsedEntity_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000B520 File Offset: 0x00009720
		public unsafe virtual bool IsParameterEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_IsParameterEntity_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000B568 File Offset: 0x00009768
		public unsafe virtual string BaseUriString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_BaseUriString_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000B5AC File Offset: 0x000097AC
		public unsafe virtual string DeclaredUriString
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_DeclaredUriString_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000B5F0 File Offset: 0x000097F0
		public unsafe virtual string SystemId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_SystemId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000B634 File Offset: 0x00009834
		public unsafe virtual string PublicId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_PublicId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000B678 File Offset: 0x00009878
		public unsafe virtual string Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000B6BC File Offset: 0x000098BC
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000B704 File Offset: 0x00009904
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdEntityInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002498 File Offset: 0x00000698
		public IDtdEntityInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExternal_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDeclaredInExternal_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnparsedEntity_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_IsParameterEntity_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUriString_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredUriString_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
