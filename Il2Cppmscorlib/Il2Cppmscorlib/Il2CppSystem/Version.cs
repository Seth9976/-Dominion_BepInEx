using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000102 RID: 258
	[Serializable]
	public sealed class Version : Object
	{
		// Token: 0x060012DB RID: 4827 RVA: 0x00079A84 File Offset: 0x00077C84
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr__Major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Major");
			Version.NativeFieldInfoPtr__Minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Minor");
			Version.NativeFieldInfoPtr__Build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Build");
			Version.NativeFieldInfoPtr__Revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "_Revision");
			Version.NativeFieldInfoPtr_SeparatorsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "SeparatorsArray");
			Version.NativeFieldInfoPtr_ZERO_CHAR_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "ZERO_CHAR_VALUE");
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666582);
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666583);
			Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666584);
			Version.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666585);
			Version.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666586);
			Version.NativeMethodInfoPtr_get_Major_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666587);
			Version.NativeMethodInfoPtr_get_Minor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666588);
			Version.NativeMethodInfoPtr_get_Build_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666589);
			Version.NativeMethodInfoPtr_get_Revision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666590);
			Version.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666591);
			Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666592);
			Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666593);
			Version.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666594);
			Version.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666595);
			Version.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666596);
			Version.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666597);
			Version.NativeMethodInfoPtr_ToString_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666598);
			Version.NativeMethodInfoPtr_AppendPositiveNumber_Private_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666599);
			Version.NativeMethodInfoPtr_Parse_Public_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666600);
			Version.NativeMethodInfoPtr_TryParseVersion_Private_Static_Boolean_String_byref_VersionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666601);
			Version.NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_String_String_byref_VersionResult_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666602);
			Version.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666603);
			Version.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666604);
			Version.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100666605);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00079D0C File Offset: 0x00077F0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303407, RefRangeEnd = 303409, XrefRangeStart = 303406, XrefRangeEnd = 303407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor, int build, int revision)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref revision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00079D80 File Offset: 0x00077F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303409, XrefRangeEnd = 303410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor, int build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00079DE4 File Offset: 0x00077FE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303411, RefRangeEnd = 303413, XrefRangeStart = 303410, XrefRangeEnd = 303411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(int major, int minor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00079E3C File Offset: 0x0007803C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303424, RefRangeEnd = 303425, XrefRangeStart = 303413, XrefRangeEnd = 303424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00079E88 File Offset: 0x00078088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303425, XrefRangeEnd = 303426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Version()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00079EC4 File Offset: 0x000780C4
		public unsafe int Major
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Major_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00079F00 File Offset: 0x00078100
		public unsafe int Minor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Minor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00079F3C File Offset: 0x0007813C
		public unsafe int Build
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Build_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00079F78 File Offset: 0x00078178
		public unsafe int Revision
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_Revision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00079FB4 File Offset: 0x000781B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303426, XrefRangeEnd = 303430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00079FF4 File Offset: 0x000781F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303430, XrefRangeEnd = 303438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0007A044 File Offset: 0x00078244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303438, XrefRangeEnd = 303446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Version value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0007A094 File Offset: 0x00078294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303446, XrefRangeEnd = 303454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0007A0E4 File Offset: 0x000782E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303458, RefRangeEnd = 303459, XrefRangeStart = 303454, XrefRangeEnd = 303458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Version obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0007A134 File Offset: 0x00078334
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0007A170 File Offset: 0x00078370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303459, XrefRangeEnd = 303462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0007A1A8 File Offset: 0x000783A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303496, RefRangeEnd = 303499, XrefRangeStart = 303462, XrefRangeEnd = 303496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(int fieldCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fieldCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_ToString_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0007A1EC File Offset: 0x000783EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 303501, RefRangeEnd = 303507, XrefRangeStart = 303499, XrefRangeEnd = 303501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendPositiveNumber(int num, StringBuilder sb)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_AppendPositiveNumber_Private_Static_Void_Int32_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0007A230 File Offset: 0x00078430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303507, XrefRangeEnd = 303514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version Parse(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_Parse_Public_Static_Version_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0007A274 File Offset: 0x00078474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303570, RefRangeEnd = 303572, XrefRangeStart = 303514, XrefRangeEnd = 303570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseVersion(string version, ref Version.VersionResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryParseVersion_Private_Static_Boolean_String_byref_VersionResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0007A2C8 File Offset: 0x000784C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303572, XrefRangeEnd = 303580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(componentName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsedComponent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_String_String_byref_VersionResult_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0007A33C File Offset: 0x0007853C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 303584, RefRangeEnd = 303603, XrefRangeStart = 303580, XrefRangeEnd = 303584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0007A390 File Offset: 0x00078590
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 303611, RefRangeEnd = 303616, XrefRangeStart = 303603, XrefRangeEnd = 303611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0007A3E4 File Offset: 0x000785E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303624, RefRangeEnd = 303625, XrefRangeStart = 303616, XrefRangeEnd = 303624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Version v1, Version v2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000067EF File Offset: 0x000049EF
		public Version(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0007A438 File Offset: 0x00078638
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x000067F8 File Offset: 0x000049F8
		public unsafe int _Major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Major)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0007A460 File Offset: 0x00078660
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00006813 File Offset: 0x00004A13
		public unsafe int _Minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Minor)) = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0007A488 File Offset: 0x00078688
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x0000682E File Offset: 0x00004A2E
		public unsafe int _Build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Build)) = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0007A4B0 File Offset: 0x000786B0
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00006849 File Offset: 0x00004A49
		public unsafe int _Revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.NativeFieldInfoPtr__Revision)) = value;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0007A4D8 File Offset: 0x000786D8
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00006864 File Offset: 0x00004A64
		public unsafe static Il2CppStructArray<char> SeparatorsArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_SeparatorsArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_SeparatorsArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x0007A500 File Offset: 0x00078700
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00006876 File Offset: 0x00004A76
		public unsafe static int ZERO_CHAR_VALUE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_ZERO_CHAR_VALUE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_ZERO_CHAR_VALUE, (void*)(&value));
			}
		}

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeFieldInfoPtr__Major;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeFieldInfoPtr__Minor;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeFieldInfoPtr__Build;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeFieldInfoPtr__Revision;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_SeparatorsArray;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_ZERO_CHAR_VALUE;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_get_Major_Public_get_Int32_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_get_Minor_Public_get_Int32_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_get_Build_Public_get_Int32_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_get_Revision_Public_get_Int32_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Version_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Version_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Int32_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_AppendPositiveNumber_Private_Static_Void_Int32_StringBuilder_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Version_String_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_TryParseVersion_Private_Static_Boolean_String_byref_VersionResult_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_TryParseComponent_Private_Static_Boolean_String_String_byref_VersionResult_byref_Int32_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Version_Version_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Version_Version_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Version_Version_0;

		// Token: 0x020005A4 RID: 1444
		public enum ParseFailureKind
		{
			// Token: 0x0400409B RID: 16539
			ArgumentNullException,
			// Token: 0x0400409C RID: 16540
			ArgumentException,
			// Token: 0x0400409D RID: 16541
			ArgumentOutOfRangeException,
			// Token: 0x0400409E RID: 16542
			FormatException
		}

		// Token: 0x020005A5 RID: 1445
		public sealed class VersionResult : ValueType
		{
			// Token: 0x06004F8E RID: 20366 RVA: 0x00165AFC File Offset: 0x00163CFC
			// Note: this type is marked as 'beforefieldinit'.
			static VersionResult()
			{
				Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Version>.NativeClassPtr, "VersionResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr);
				Version.VersionResult.NativeFieldInfoPtr_m_parsedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_parsedVersion");
				Version.VersionResult.NativeFieldInfoPtr_m_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_failure");
				Version.VersionResult.NativeFieldInfoPtr_m_exceptionArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_exceptionArgument");
				Version.VersionResult.NativeFieldInfoPtr_m_argumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_argumentName");
				Version.VersionResult.NativeFieldInfoPtr_m_canThrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, "m_canThrow");
				Version.VersionResult.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666607);
				Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666608);
				Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666609);
				Version.VersionResult.NativeMethodInfoPtr_GetVersionParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr, 100666610);
			}

			// Token: 0x06004F8F RID: 20367 RVA: 0x00165BDC File Offset: 0x00163DDC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303387, RefRangeEnd = 303389, XrefRangeStart = 303387, XrefRangeEnd = 303387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(string argumentName, bool canThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(argumentName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canThrow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F90 RID: 20368 RVA: 0x00165C34 File Offset: 0x00163E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303389, XrefRangeEnd = 303391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Version.ParseFailureKind failure)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F91 RID: 20369 RVA: 0x00165C78 File Offset: 0x00163E78
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 303391, RefRangeEnd = 303393, XrefRangeStart = 303391, XrefRangeEnd = 303391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Version.ParseFailureKind failure, string argument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F92 RID: 20370 RVA: 0x00165CD0 File Offset: 0x00163ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303393, XrefRangeEnd = 303406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetVersionParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.VersionResult.NativeMethodInfoPtr_GetVersionParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x06004F93 RID: 20371 RVA: 0x0001E292 File Offset: 0x0001C492
			public VersionResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004F94 RID: 20372 RVA: 0x0001E29B File Offset: 0x0001C49B
			public VersionResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Version.VersionResult>.NativeClassPtr))
			{
			}

			// Token: 0x1700143F RID: 5183
			// (get) Token: 0x06004F95 RID: 20373 RVA: 0x00165D14 File Offset: 0x00163F14
			// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0001E2AD File Offset: 0x0001C4AD
			public unsafe Version m_parsedVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_parsedVersion);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_parsedVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001440 RID: 5184
			// (get) Token: 0x06004F97 RID: 20375 RVA: 0x00165D44 File Offset: 0x00163F44
			// (set) Token: 0x06004F98 RID: 20376 RVA: 0x0001E2CC File Offset: 0x0001C4CC
			public unsafe Version.ParseFailureKind m_failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_failure)) = value;
				}
			}

			// Token: 0x17001441 RID: 5185
			// (get) Token: 0x06004F99 RID: 20377 RVA: 0x00165D6C File Offset: 0x00163F6C
			// (set) Token: 0x06004F9A RID: 20378 RVA: 0x0001E2E7 File Offset: 0x0001C4E7
			public unsafe string m_exceptionArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_exceptionArgument);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_exceptionArgument), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001442 RID: 5186
			// (get) Token: 0x06004F9B RID: 20379 RVA: 0x00165D94 File Offset: 0x00163F94
			// (set) Token: 0x06004F9C RID: 20380 RVA: 0x0001E306 File Offset: 0x0001C506
			public unsafe string m_argumentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_argumentName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_argumentName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001443 RID: 5187
			// (get) Token: 0x06004F9D RID: 20381 RVA: 0x00165DBC File Offset: 0x00163FBC
			// (set) Token: 0x06004F9E RID: 20382 RVA: 0x0001E325 File Offset: 0x0001C525
			public unsafe bool m_canThrow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_canThrow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Version.VersionResult.NativeFieldInfoPtr_m_canThrow)) = value;
				}
			}

			// Token: 0x0400409F RID: 16543
			private static readonly IntPtr NativeFieldInfoPtr_m_parsedVersion;

			// Token: 0x040040A0 RID: 16544
			private static readonly IntPtr NativeFieldInfoPtr_m_failure;

			// Token: 0x040040A1 RID: 16545
			private static readonly IntPtr NativeFieldInfoPtr_m_exceptionArgument;

			// Token: 0x040040A2 RID: 16546
			private static readonly IntPtr NativeFieldInfoPtr_m_argumentName;

			// Token: 0x040040A3 RID: 16547
			private static readonly IntPtr NativeFieldInfoPtr_m_canThrow;

			// Token: 0x040040A4 RID: 16548
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0;

			// Token: 0x040040A5 RID: 16549
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_0;

			// Token: 0x040040A6 RID: 16550
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x040040A7 RID: 16551
			private static readonly IntPtr NativeMethodInfoPtr_GetVersionParseException_Internal_Exception_0;
		}
	}
}
