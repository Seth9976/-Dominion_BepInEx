using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class PayoutDefinition : Object
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003908 File Offset: 0x00001B08
		// Note: this type is marked as 'beforefieldinit'.
		static PayoutDefinition()
		{
			Il2CppClassPointerStore<PayoutDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "PayoutDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayoutDefinition>.NativeClassPtr);
			PayoutDefinition.NativeFieldInfoPtr_m_Subtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayoutDefinition>.NativeClassPtr, "m_Subtype");
			PayoutDefinition.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayoutDefinition>.NativeClassPtr, "m_Data");
			PayoutDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayoutDefinition>.NativeClassPtr, 100663325);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003974 File Offset: 0x00001B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130604, XrefRangeEnd = 130608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayoutDefinition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayoutDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayoutDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000219F File Offset: 0x0000039F
		public PayoutDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000039B0 File Offset: 0x00001BB0
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000021A8 File Offset: 0x000003A8
		public unsafe string m_Subtype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayoutDefinition.NativeFieldInfoPtr_m_Subtype);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayoutDefinition.NativeFieldInfoPtr_m_Subtype), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021C7 File Offset: 0x000003C7
		public unsafe string m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayoutDefinition.NativeFieldInfoPtr_m_Data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayoutDefinition.NativeFieldInfoPtr_m_Data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_Subtype;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
