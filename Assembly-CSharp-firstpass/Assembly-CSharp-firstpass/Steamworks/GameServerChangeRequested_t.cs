using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200017A RID: 378
	public sealed class GameServerChangeRequested_t : ValueType
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x0009FC90 File Offset: 0x0009DE90
		// Note: this type is marked as 'beforefieldinit'.
		static GameServerChangeRequested_t()
		{
			Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameServerChangeRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr);
			GameServerChangeRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "k_iCallback");
			GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchServer_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "m_rgchServer_");
			GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchPassword_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, "m_rgchPassword_");
			GameServerChangeRequested_t.NativeMethodInfoPtr_get_m_rgchServer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100668331);
			GameServerChangeRequested_t.NativeMethodInfoPtr_set_m_rgchServer_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100668332);
			GameServerChangeRequested_t.NativeMethodInfoPtr_get_m_rgchPassword_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100668333);
			GameServerChangeRequested_t.NativeMethodInfoPtr_set_m_rgchPassword_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr, 100668334);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0009FD4C File Offset: 0x0009DF4C
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x0009FD88 File Offset: 0x0009DF88
		public unsafe string m_rgchServer
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206856, XrefRangeEnd = 206857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_get_m_rgchServer_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206857, XrefRangeEnd = 206858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_set_m_rgchServer_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0009FDD0 File Offset: 0x0009DFD0
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0009FE0C File Offset: 0x0009E00C
		public unsafe string m_rgchPassword
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206858, XrefRangeEnd = 206859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_get_m_rgchPassword_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206859, XrefRangeEnd = 206860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServerChangeRequested_t.NativeMethodInfoPtr_set_m_rgchPassword_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0000BDDF File Offset: 0x00009FDF
		public GameServerChangeRequested_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public GameServerChangeRequested_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameServerChangeRequested_t>.NativeClassPtr))
		{
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x0009FE54 File Offset: 0x0009E054
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x0000BDFA File Offset: 0x00009FFA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameServerChangeRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameServerChangeRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0009FE70 File Offset: 0x0009E070
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x0000BE08 File Offset: 0x0000A008
		public unsafe Il2CppStructArray<byte> m_rgchServer_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchServer_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchServer_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0009FEA0 File Offset: 0x0009E0A0
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0000BE27 File Offset: 0x0000A027
		public unsafe Il2CppStructArray<byte> m_rgchPassword_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchPassword_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameServerChangeRequested_t.NativeFieldInfoPtr_m_rgchPassword_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchServer_;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchPassword_;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchServer_Public_get_String_0;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchServer_Public_set_Void_String_0;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchPassword_Public_get_String_0;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchPassword_Public_set_Void_String_0;
	}
}
