using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200023D RID: 573
	public sealed class GetVideoURLResult_t : ValueType
	{
		// Token: 0x06002595 RID: 9621 RVA: 0x000A938C File Offset: 0x000A758C
		// Note: this type is marked as 'beforefieldinit'.
		static GetVideoURLResult_t()
		{
			Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetVideoURLResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr);
			GetVideoURLResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "k_iCallback");
			GetVideoURLResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "m_eResult");
			GetVideoURLResult_t.NativeFieldInfoPtr_m_unVideoAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "m_unVideoAppID");
			GetVideoURLResult_t.NativeFieldInfoPtr_m_rgchURL_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, "m_rgchURL_");
			GetVideoURLResult_t.NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, 100668377);
			GetVideoURLResult_t.NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr, 100668378);
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000A9434 File Offset: 0x000A7634
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x000A9470 File Offset: 0x000A7670
		public unsafe string m_rgchURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetVideoURLResult_t.NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetVideoURLResult_t.NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0000EE5F File Offset: 0x0000D05F
		public GetVideoURLResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x0000EE68 File Offset: 0x0000D068
		public GetVideoURLResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetVideoURLResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000A94B8 File Offset: 0x000A76B8
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x0000EE7A File Offset: 0x0000D07A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetVideoURLResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetVideoURLResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000A94D4 File Offset: 0x000A76D4
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x0000EE88 File Offset: 0x0000D088
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000A94FC File Offset: 0x000A76FC
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x0000EEA3 File Offset: 0x0000D0A3
		public unsafe AppId_t m_unVideoAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_unVideoAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_unVideoAppID)) = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000A9524 File Offset: 0x000A7724
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x0000EEBE File Offset: 0x0000D0BE
		public unsafe Il2CppStructArray<byte> m_rgchURL_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_rgchURL_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetVideoURLResult_t.NativeFieldInfoPtr_m_rgchURL_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_m_unVideoAppID;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchURL_;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0;
	}
}
