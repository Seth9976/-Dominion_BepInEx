using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000240 RID: 576
	[Serializable]
	public sealed class SortVersion : Object
	{
		// Token: 0x06002714 RID: 10004 RVA: 0x000CE708 File Offset: 0x000CC908
		// Note: this type is marked as 'beforefieldinit'.
		static SortVersion()
		{
			Il2CppClassPointerStore<SortVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "SortVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortVersion>.NativeClassPtr);
			SortVersion.NativeFieldInfoPtr_m_NlsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, "m_NlsVersion");
			SortVersion.NativeFieldInfoPtr_m_SortId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, "m_SortId");
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0000D77C File Offset: 0x0000B97C
		public SortVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x000CE760 File Offset: 0x000CC960
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x0000D785 File Offset: 0x0000B985
		public unsafe int m_NlsVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_NlsVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_NlsVersion)) = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x000CE788 File Offset: 0x000CC988
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		public unsafe Guid m_SortId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_SortId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_SortId)) = value;
			}
		}

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeFieldInfoPtr_m_NlsVersion;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeFieldInfoPtr_m_SortId;
	}
}
