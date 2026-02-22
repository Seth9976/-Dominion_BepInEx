using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200024B RID: 587
	public sealed class InternalEncodingDataItem : ValueType
	{
		// Token: 0x0600284E RID: 10318 RVA: 0x000D3B8C File Offset: 0x000D1D8C
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncodingDataItem()
		{
			Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "InternalEncodingDataItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr);
			InternalEncodingDataItem.NativeFieldInfoPtr_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "webName");
			InternalEncodingDataItem.NativeFieldInfoPtr_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr, "codePage");
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0000DE00 File Offset: 0x0000C000
		public InternalEncodingDataItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0000DE09 File Offset: 0x0000C009
		public InternalEncodingDataItem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncodingDataItem>.NativeClassPtr))
		{
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x000D3BE4 File Offset: 0x000D1DE4
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x0000DE1B File Offset: 0x0000C01B
		public unsafe string webName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_webName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_webName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x000D3C0C File Offset: 0x000D1E0C
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x0000DE3A File Offset: 0x0000C03A
		public unsafe ushort codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncodingDataItem.NativeFieldInfoPtr_codePage)) = value;
			}
		}

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeFieldInfoPtr_webName;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeFieldInfoPtr_codePage;
	}
}
