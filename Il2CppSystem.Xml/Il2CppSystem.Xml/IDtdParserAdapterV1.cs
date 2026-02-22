using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000018 RID: 24
	public class IDtdParserAdapterV1 : Il2CppObjectBase
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapterV1()
		{
			Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapterV1");
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663420);
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663421);
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663422);
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000C460 File Offset: 0x0000A660
		public unsafe virtual bool V1CompatibilityMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		public unsafe virtual bool Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		public unsafe virtual bool Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000024BC File Offset: 0x000006BC
		public IDtdParserAdapterV1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
