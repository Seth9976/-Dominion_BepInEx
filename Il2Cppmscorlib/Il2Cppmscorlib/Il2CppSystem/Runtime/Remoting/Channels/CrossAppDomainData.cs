using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class CrossAppDomainData : Object
	{
		// Token: 0x06003E0D RID: 15885 RVA: 0x00122648 File Offset: 0x00120848
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainData()
		{
			Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr);
			CrossAppDomainData.NativeFieldInfoPtr__ContextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_ContextID");
			CrossAppDomainData.NativeFieldInfoPtr__DomainID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_DomainID");
			CrossAppDomainData.NativeFieldInfoPtr__processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_processGuid");
			CrossAppDomainData.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100672422);
			CrossAppDomainData.NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100672423);
			CrossAppDomainData.NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100672424);
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x001226F0 File Offset: 0x001208F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353394, RefRangeEnd = 353395, XrefRangeStart = 353386, XrefRangeEnd = 353394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainData(int domainId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06003E0F RID: 15887 RVA: 0x00122738 File Offset: 0x00120938
		public unsafe int DomainID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x00122774 File Offset: 0x00120974
		public unsafe string ProcessID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00017612 File Offset: 0x00015812
		public CrossAppDomainData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x001227AC File Offset: 0x001209AC
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x0001761B File Offset: 0x0001581B
		public unsafe Object _ContextID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__ContextID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__ContextID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x001227DC File Offset: 0x001209DC
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x0001763A File Offset: 0x0001583A
		public unsafe int _DomainID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__DomainID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__DomainID)) = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x00122804 File Offset: 0x00120A04
		// (set) Token: 0x06003E17 RID: 15895 RVA: 0x00017655 File Offset: 0x00015855
		public unsafe string _processGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__processGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__processGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeFieldInfoPtr__ContextID;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeFieldInfoPtr__DomainID;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeFieldInfoPtr__processGuid;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0;

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0;
	}
}
