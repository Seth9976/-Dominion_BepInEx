using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000228 RID: 552
	public sealed class StoreAuthURLResponse_t : ValueType
	{
		// Token: 0x06002524 RID: 9508 RVA: 0x000A843C File Offset: 0x000A663C
		// Note: this type is marked as 'beforefieldinit'.
		static StoreAuthURLResponse_t()
		{
			Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "StoreAuthURLResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr);
			StoreAuthURLResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, "k_iCallback");
			StoreAuthURLResponse_t.NativeFieldInfoPtr_m_szURL_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, "m_szURL_");
			StoreAuthURLResponse_t.NativeMethodInfoPtr_get_m_szURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, 100668371);
			StoreAuthURLResponse_t.NativeMethodInfoPtr_set_m_szURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr, 100668372);
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000A84BC File Offset: 0x000A66BC
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x000A84F8 File Offset: 0x000A66F8
		public unsafe string m_szURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreAuthURLResponse_t.NativeMethodInfoPtr_get_m_szURL_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206887, XrefRangeEnd = 206888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreAuthURLResponse_t.NativeMethodInfoPtr_set_m_szURL_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0000EA18 File Offset: 0x0000CC18
		public StoreAuthURLResponse_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0000EA21 File Offset: 0x0000CC21
		public StoreAuthURLResponse_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreAuthURLResponse_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000A8540 File Offset: 0x000A6740
		// (set) Token: 0x0600252A RID: 9514 RVA: 0x0000EA33 File Offset: 0x0000CC33
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StoreAuthURLResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoreAuthURLResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x000A855C File Offset: 0x000A675C
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x0000EA41 File Offset: 0x0000CC41
		public unsafe Il2CppStructArray<byte> m_szURL_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreAuthURLResponse_t.NativeFieldInfoPtr_m_szURL_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreAuthURLResponse_t.NativeFieldInfoPtr_m_szURL_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeFieldInfoPtr_m_szURL_;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_get_m_szURL_Public_get_String_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_set_m_szURL_Public_set_Void_String_0;
	}
}
