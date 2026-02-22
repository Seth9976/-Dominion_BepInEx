using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000017 RID: 23
	public class IDtdParserAdapterWithValidation : Il2CppObjectBase
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x0000C318 File Offset: 0x0000A518
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapterWithValidation()
		{
			Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapterWithValidation");
			IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr, 100663418);
			IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr, 100663419);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000C368 File Offset: 0x0000A568
		public unsafe virtual bool DtdValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public unsafe virtual IValidationEventHandling ValidationEventHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000024B3 File Offset: 0x000006B3
		public IDtdParserAdapterWithValidation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0;
	}
}
