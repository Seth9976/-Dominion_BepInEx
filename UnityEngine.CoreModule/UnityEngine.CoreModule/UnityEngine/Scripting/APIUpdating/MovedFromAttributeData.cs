using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x02000113 RID: 275
	public sealed class MovedFromAttributeData : ValueType
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x00055514 File Offset: 0x00053714
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttributeData()
		{
			Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttributeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr);
			MovedFromAttributeData.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "className");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpace");
			MovedFromAttributeData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assembly");
			MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "classHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "nameSpaceHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "assemblyHasChanged");
			MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, "autoUdpateAPI");
			MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, 100664972);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000555E4 File Offset: 0x000537E4
		[CallerCount(0)]
		public unsafe void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoUpdateAPI;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0000CA1E File Offset: 0x0000AC1E
		public MovedFromAttributeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0000CA27 File Offset: 0x0000AC27
		public MovedFromAttributeData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr))
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00055660 File Offset: 0x00053860
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x0000CA39 File Offset: 0x0000AC39
		public unsafe string className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00055688 File Offset: 0x00053888
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x0000CA58 File Offset: 0x0000AC58
		public unsafe string nameSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x000556B0 File Offset: 0x000538B0
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x0000CA77 File Offset: 0x0000AC77
		public unsafe string assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x000556D8 File Offset: 0x000538D8
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x0000CA96 File Offset: 0x0000AC96
		public unsafe bool classHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x00055700 File Offset: 0x00053900
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
		public unsafe bool nameSpaceHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged)) = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00055728 File Offset: 0x00053928
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0000CACC File Offset: 0x0000ACCC
		public unsafe bool assemblyHasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged)) = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00055750 File Offset: 0x00053950
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x0000CAE7 File Offset: 0x0000ACE7
		public unsafe bool autoUdpateAPI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI)) = value;
			}
		}

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr_className;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr_nameSpace;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr_classHasChanged;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr_nameSpaceHasChanged;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr_assemblyHasChanged;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeFieldInfoPtr_autoUdpateAPI;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0;
	}
}
