using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000227 RID: 551
	public sealed class GameWebCallback_t : ValueType
	{
		// Token: 0x0600251B RID: 9499 RVA: 0x000A82EC File Offset: 0x000A64EC
		// Note: this type is marked as 'beforefieldinit'.
		static GameWebCallback_t()
		{
			Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameWebCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr);
			GameWebCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, "k_iCallback");
			GameWebCallback_t.NativeFieldInfoPtr_m_szURL_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, "m_szURL_");
			GameWebCallback_t.NativeMethodInfoPtr_get_m_szURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, 100668369);
			GameWebCallback_t.NativeMethodInfoPtr_set_m_szURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr, 100668370);
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000A836C File Offset: 0x000A656C
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x000A83A8 File Offset: 0x000A65A8
		public unsafe string m_szURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameWebCallback_t.NativeMethodInfoPtr_get_m_szURL_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206886, XrefRangeEnd = 206887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameWebCallback_t.NativeMethodInfoPtr_set_m_szURL_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public GameWebCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
		public GameWebCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameWebCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000A83F0 File Offset: 0x000A65F0
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x0000E9EB File Offset: 0x0000CBEB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameWebCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameWebCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000A840C File Offset: 0x000A660C
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0000E9F9 File Offset: 0x0000CBF9
		public unsafe Il2CppStructArray<byte> m_szURL_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameWebCallback_t.NativeFieldInfoPtr_m_szURL_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameWebCallback_t.NativeFieldInfoPtr_m_szURL_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeFieldInfoPtr_m_szURL_;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_get_m_szURL_Public_get_String_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_set_m_szURL_Public_set_Void_String_0;
	}
}
