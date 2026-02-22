using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024C RID: 588
	public sealed class InternalCodePageDataItem : ValueType
	{
		// Token: 0x06002855 RID: 10325 RVA: 0x000D3C34 File Offset: 0x000D1E34
		// Note: this type is marked as 'beforefieldinit'.
		static InternalCodePageDataItem()
		{
			Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalCodePageDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr);
			InternalCodePageDataItem.NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "codePage");
			InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "uiFamilyCodePage");
			InternalCodePageDataItem.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "flags");
			InternalCodePageDataItem.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr, "Names");
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0000DE55 File Offset: 0x0000C055
		public InternalCodePageDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0000DE5E File Offset: 0x0000C05E
		public InternalCodePageDataItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalCodePageDataItem>.NativeClassPtr))
		{
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000D3CB4 File Offset: 0x000D1EB4
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x0000DE70 File Offset: 0x0000C070
		public unsafe ushort codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_codePage)) = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x000D3CDC File Offset: 0x000D1EDC
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x0000DE8B File Offset: 0x0000C08B
		public unsafe ushort uiFamilyCodePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_uiFamilyCodePage)) = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000D3D04 File Offset: 0x000D1F04
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x0000DEA6 File Offset: 0x0000C0A6
		public unsafe uint flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000D3D2C File Offset: 0x000D1F2C
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x0000DEC1 File Offset: 0x0000C0C1
		public unsafe string Names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_Names);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalCodePageDataItem.NativeFieldInfoPtr_Names), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeFieldInfoPtr_codePage;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeFieldInfoPtr_uiFamilyCodePage;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeFieldInfoPtr_Names;
	}
}
