using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Policy;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001CC RID: 460
	public class RuntimeAssembly : Assembly
	{
		// Token: 0x06001DA9 RID: 7593 RVA: 0x000A6C8C File Offset: 0x000A4E8C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeAssembly()
		{
			Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr);
			RuntimeAssembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100668209);
			RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_String_Evidence_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100668210);
			RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_AssemblyName_Evidence_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100668211);
			RuntimeAssembly.NativeMethodInfoPtr_GetName_Public_Virtual_AssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100668212);
			RuntimeAssembly.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr, 100668213);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000A6D20 File Offset: 0x000A4F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318401, XrefRangeEnd = 318402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000A6D84 File Offset: 0x000A4F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318405, RefRangeEnd = 318406, XrefRangeStart = 318402, XrefRangeEnd = 318405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(partialName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_String_Evidence_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000A6DE8 File Offset: 0x000A4FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318409, RefRangeEnd = 318410, XrefRangeStart = 318406, XrefRangeEnd = 318409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(an);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(securityEvidence);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_AssemblyName_Evidence_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000A6E4C File Offset: 0x000A504C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318410, XrefRangeEnd = 318411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AssemblyName GetName(bool copiedName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref copiedName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeAssembly.NativeMethodInfoPtr_GetName_Public_Virtual_AssemblyName_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssemblyName>(intPtr3) : null;
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000A6EA4 File Offset: 0x000A50A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318412, RefRangeEnd = 318413, XrefRangeStart = 318411, XrefRangeEnd = 318412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeAssembly.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0000A3E6 File Offset: 0x000085E6
		public RuntimeAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_String_Evidence_byref_StackCrawlMark_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_LoadWithPartialNameInternal_Internal_Static_RuntimeAssembly_AssemblyName_Evidence_byref_StackCrawlMark_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_AssemblyName_Boolean_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
