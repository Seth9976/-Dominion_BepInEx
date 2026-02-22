using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine._Scripting.APIUpdating
{
	// Token: 0x020000E3 RID: 227
	public class APIUpdaterRuntimeHelpers : Object
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x0004DBB8 File Offset: 0x0004BDB8
		// Note: this type is marked as 'beforefieldinit'.
		static APIUpdaterRuntimeHelpers()
		{
			Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine._Scripting.APIUpdating", "APIUpdaterRuntimeHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr);
			APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100664745);
			APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100664746);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0004DC10 File Offset: 0x0004BE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79458, XrefRangeEnd = 79466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			assembly = IL2CPP.Il2CppStringToManaged(intPtr);
			nsp = IL2CPP.Il2CppStringToManaged(intPtr2);
			klass = IL2CPP.Il2CppStringToManaged(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79466, XrefRangeEnd = 79492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			nsp = IL2CPP.Il2CppStringToManaged(intPtr2);
			className = IL2CPP.Il2CppStringToManaged(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0000B939 File Offset: 0x00009B39
		public APIUpdaterRuntimeHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;
	}
}
