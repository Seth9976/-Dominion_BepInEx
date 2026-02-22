using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class GD_WorksheetTemplate : Object
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x00005830 File Offset: 0x00003A30
		// Note: this type is marked as 'beforefieldinit'.
		static GD_WorksheetTemplate()
		{
			Il2CppClassPointerStore<GD_WorksheetTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_WorksheetTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_WorksheetTemplate>.NativeClassPtr);
			GD_WorksheetTemplate.NativeFieldInfoPtr_ListName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_WorksheetTemplate>.NativeClassPtr, "ListName");
			GD_WorksheetTemplate.NativeFieldInfoPtr_ListId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_WorksheetTemplate>.NativeClassPtr, "ListId");
			GD_WorksheetTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_WorksheetTemplate>.NativeClassPtr, 100663395);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000589C File Offset: 0x00003A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126432, RefRangeEnd = 126433, XrefRangeStart = 126431, XrefRangeEnd = 126432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_WorksheetTemplate(string name, int id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_WorksheetTemplate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_WorksheetTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000024A6 File Offset: 0x000006A6
		public GD_WorksheetTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000058F8 File Offset: 0x00003AF8
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000024AF File Offset: 0x000006AF
		public unsafe string ListName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_WorksheetTemplate.NativeFieldInfoPtr_ListName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_WorksheetTemplate.NativeFieldInfoPtr_ListName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005920 File Offset: 0x00003B20
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000024CE File Offset: 0x000006CE
		public unsafe int ListId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_WorksheetTemplate.NativeFieldInfoPtr_ListId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_WorksheetTemplate.NativeFieldInfoPtr_ListId)) = value;
			}
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_ListName;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_ListId;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
