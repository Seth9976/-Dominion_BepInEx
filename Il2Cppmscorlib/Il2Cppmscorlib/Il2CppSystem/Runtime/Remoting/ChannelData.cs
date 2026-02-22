using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000397 RID: 919
	public class ChannelData : Object
	{
		// Token: 0x06003BEB RID: 15339 RVA: 0x0011A618 File Offset: 0x00118818
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelData()
		{
			Il2CppClassPointerStore<ChannelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ChannelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelData>.NativeClassPtr);
			ChannelData.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Ref");
			ChannelData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Type");
			ChannelData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "Id");
			ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "DelayLoadAsClientChannel");
			ChannelData.NativeFieldInfoPtr__serverProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_serverProviders");
			ChannelData.NativeFieldInfoPtr__clientProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_clientProviders");
			ChannelData.NativeFieldInfoPtr__customProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, "_customProperties");
			ChannelData.NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672142);
			ChannelData.NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672143);
			ChannelData.NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672144);
			ChannelData.NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672145);
			ChannelData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelData>.NativeClassPtr, 100672146);
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x0011A738 File Offset: 0x00118938
		public unsafe ArrayList ServerProviders
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 350090, RefRangeEnd = 350092, XrefRangeStart = 350086, XrefRangeEnd = 350090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0011A778 File Offset: 0x00118978
		public unsafe ArrayList ClientProviders
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 350096, RefRangeEnd = 350098, XrefRangeStart = 350092, XrefRangeEnd = 350096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x0011A7B8 File Offset: 0x001189B8
		public unsafe Hashtable CustomProperties
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 350102, RefRangeEnd = 350107, XrefRangeStart = 350098, XrefRangeEnd = 350102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06003BEF RID: 15343 RVA: 0x0011A7F8 File Offset: 0x001189F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350170, RefRangeEnd = 350171, XrefRangeStart = 350107, XrefRangeEnd = 350170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(ChannelData other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BF0 RID: 15344 RVA: 0x0011A83C File Offset: 0x00118A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350171, XrefRangeEnd = 350183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChannelData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChannelData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x000168F4 File Offset: 0x00014AF4
		public ChannelData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x0011A878 File Offset: 0x00118A78
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x000168FD File Offset: 0x00014AFD
		public unsafe string Ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Ref);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Ref), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x0011A8A0 File Offset: 0x00118AA0
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x0001691C File Offset: 0x00014B1C
		public unsafe string Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x0011A8C8 File Offset: 0x00118AC8
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x0001693B File Offset: 0x00014B3B
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x0011A8F0 File Offset: 0x00118AF0
		// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x0001695A File Offset: 0x00014B5A
		public unsafe string DelayLoadAsClientChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr_DelayLoadAsClientChannel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06003BFA RID: 15354 RVA: 0x0011A918 File Offset: 0x00118B18
		// (set) Token: 0x06003BFB RID: 15355 RVA: 0x00016979 File Offset: 0x00014B79
		public unsafe ArrayList _serverProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__serverProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__serverProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x0011A948 File Offset: 0x00118B48
		// (set) Token: 0x06003BFD RID: 15357 RVA: 0x00016998 File Offset: 0x00014B98
		public unsafe ArrayList _clientProviders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__clientProviders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__clientProviders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06003BFE RID: 15358 RVA: 0x0011A978 File Offset: 0x00118B78
		// (set) Token: 0x06003BFF RID: 15359 RVA: 0x000169B7 File Offset: 0x00014BB7
		public unsafe Hashtable _customProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__customProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChannelData.NativeFieldInfoPtr__customProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x040031CC RID: 12748
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040031CD RID: 12749
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040031CE RID: 12750
		private static readonly IntPtr NativeFieldInfoPtr_DelayLoadAsClientChannel;

		// Token: 0x040031CF RID: 12751
		private static readonly IntPtr NativeFieldInfoPtr__serverProviders;

		// Token: 0x040031D0 RID: 12752
		private static readonly IntPtr NativeFieldInfoPtr__clientProviders;

		// Token: 0x040031D1 RID: 12753
		private static readonly IntPtr NativeFieldInfoPtr__customProperties;

		// Token: 0x040031D2 RID: 12754
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerProviders_Internal_get_ArrayList_0;

		// Token: 0x040031D3 RID: 12755
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientProviders_Public_get_ArrayList_0;

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomProperties_Public_get_Hashtable_0;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_ChannelData_0;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
