using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200021B RID: 539
	public sealed class GetAppDependenciesResult_t : ValueType
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x000A7C30 File Offset: 0x000A5E30
		// Note: this type is marked as 'beforefieldinit'.
		static GetAppDependenciesResult_t()
		{
			Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetAppDependenciesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr);
			GetAppDependenciesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "k_iCallback");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_eResult");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_nPublishedFileId");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_rgAppIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_rgAppIDs");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nNumAppDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_nNumAppDependencies");
			GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nTotalNumAppDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr, "m_nTotalNumAppDependencies");
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x0000E74A File Offset: 0x0000C94A
		public GetAppDependenciesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0000E753 File Offset: 0x0000C953
		public GetAppDependenciesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetAppDependenciesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060024E3 RID: 9443 RVA: 0x000A7CD8 File Offset: 0x000A5ED8
		// (set) Token: 0x060024E4 RID: 9444 RVA: 0x0000E765 File Offset: 0x0000C965
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetAppDependenciesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetAppDependenciesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x000A7CF4 File Offset: 0x000A5EF4
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x0000E773 File Offset: 0x0000C973
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x000A7D1C File Offset: 0x000A5F1C
		// (set) Token: 0x060024E8 RID: 9448 RVA: 0x0000E78E File Offset: 0x0000C98E
		public unsafe PublishedFileId_t m_nPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nPublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nPublishedFileId)) = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x000A7D44 File Offset: 0x000A5F44
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x0000E7A9 File Offset: 0x0000C9A9
		public unsafe Il2CppStructArray<AppId_t> m_rgAppIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_rgAppIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AppId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_rgAppIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x000A7D74 File Offset: 0x000A5F74
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		public unsafe uint m_nNumAppDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nNumAppDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nNumAppDependencies)) = value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000A7D9C File Offset: 0x000A5F9C
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x0000E7E3 File Offset: 0x0000C9E3
		public unsafe uint m_nTotalNumAppDependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nTotalNumAppDependencies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetAppDependenciesResult_t.NativeFieldInfoPtr_m_nTotalNumAppDependencies)) = value;
			}
		}

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeFieldInfoPtr_m_rgAppIDs;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeFieldInfoPtr_m_nNumAppDependencies;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalNumAppDependencies;
	}
}
