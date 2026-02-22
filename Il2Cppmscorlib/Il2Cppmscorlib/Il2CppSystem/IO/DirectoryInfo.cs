using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public sealed class DirectoryInfo : FileSystemInfo
	{
		// Token: 0x0600227F RID: 8831 RVA: 0x000BCFE8 File Offset: 0x000BB1E8
		// Note: this type is marked as 'beforefieldinit'.
		static DirectoryInfo()
		{
			Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DirectoryInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr);
			DirectoryInfo.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, "current");
			DirectoryInfo.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, "parent");
			DirectoryInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669075);
			DirectoryInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669076);
			DirectoryInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669077);
			DirectoryInfo.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669078);
			DirectoryInfo.NativeMethodInfoPtr_get_Exists_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669079);
			DirectoryInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669080);
			DirectoryInfo.NativeMethodInfoPtr_get_Parent_Public_get_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669081);
			DirectoryInfo.NativeMethodInfoPtr_Create_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669082);
			DirectoryInfo.NativeMethodInfoPtr_GetDirectories_Public_Il2CppReferenceArray_1_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669083);
			DirectoryInfo.NativeMethodInfoPtr_GetDirectories_Public_Il2CppReferenceArray_1_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669084);
			DirectoryInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669085);
			DirectoryInfo.NativeMethodInfoPtr_CheckPath_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr, 100669086);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000BD130 File Offset: 0x000BB330
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 322434, RefRangeEnd = 322439, XrefRangeStart = 322426, XrefRangeEnd = 322434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryInfo(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000BD17C File Offset: 0x000BB37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322450, RefRangeEnd = 322451, XrefRangeStart = 322439, XrefRangeEnd = 322450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryInfo(string path, bool simpleOriginalPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref simpleOriginalPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000BD1D8 File Offset: 0x000BB3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322451, XrefRangeEnd = 322453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000BD23C File Offset: 0x000BB43C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322482, RefRangeEnd = 322486, XrefRangeStart = 322453, XrefRangeEnd = 322482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x000BD270 File Offset: 0x000BB470
		public unsafe override bool Exists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322486, XrefRangeEnd = 322487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_get_Exists_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x000BD2AC File Offset: 0x000BB4AC
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x000BD2E4 File Offset: 0x000BB4E4
		public unsafe DirectoryInfo Parent
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322491, RefRangeEnd = 322493, XrefRangeStart = 322487, XrefRangeEnd = 322491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_get_Parent_Public_get_DirectoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000BD324 File Offset: 0x000BB524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322493, XrefRangeEnd = 322494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_Create_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000BD358 File Offset: 0x000BB558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322497, RefRangeEnd = 322499, XrefRangeStart = 322494, XrefRangeEnd = 322497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DirectoryInfo> GetDirectories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_GetDirectories_Public_Il2CppReferenceArray_1_DirectoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DirectoryInfo>>(intPtr3) : null;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000BD398 File Offset: 0x000BB598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322516, RefRangeEnd = 322517, XrefRangeStart = 322499, XrefRangeEnd = 322516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DirectoryInfo> GetDirectories(string searchPattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_GetDirectories_Public_Il2CppReferenceArray_1_DirectoryInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DirectoryInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000BD3E8 File Offset: 0x000BB5E8
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000BD420 File Offset: 0x000BB620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322524, RefRangeEnd = 322527, XrefRangeStart = 322517, XrefRangeEnd = 322524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPath(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryInfo.NativeMethodInfoPtr_CheckPath_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x0000BB51 File Offset: 0x00009D51
		public DirectoryInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x000BD464 File Offset: 0x000BB664
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0000BB5A File Offset: 0x00009D5A
		public unsafe string current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectoryInfo.NativeFieldInfoPtr_current);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectoryInfo.NativeFieldInfoPtr_current), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x000BD48C File Offset: 0x000BB68C
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x0000BB79 File Offset: 0x00009D79
		public unsafe string parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectoryInfo.NativeFieldInfoPtr_parent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirectoryInfo.NativeFieldInfoPtr_parent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_get_Exists_Public_Virtual_get_Boolean_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_DirectoryInfo_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Void_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Il2CppReferenceArray_1_DirectoryInfo_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Il2CppReferenceArray_1_DirectoryInfo_String_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_CheckPath_Internal_Void_String_0;
	}
}
