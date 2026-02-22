using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000354 RID: 852
	public sealed class BinaryAssemblyInfo : Object
	{
		// Token: 0x06003668 RID: 13928 RVA: 0x00108520 File Offset: 0x00106720
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryAssemblyInfo()
		{
			Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryAssemblyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr);
			BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assemblyString");
			BinaryAssemblyInfo.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, "assembly");
			BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671673);
			BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671674);
			BinaryAssemblyInfo.NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr, 100671675);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x001085B4 File Offset: 0x001067B4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssemblyInfo(string assemblyString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x00108600 File Offset: 0x00106800
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryAssemblyInfo(string assemblyString, Assembly assembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryAssemblyInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00108660 File Offset: 0x00106860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344940, RefRangeEnd = 344941, XrefRangeStart = 344934, XrefRangeEnd = 344940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assembly GetAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryAssemblyInfo.NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x000138E9 File Offset: 0x00011AE9
		public BinaryAssemblyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x001086A0 File Offset: 0x001068A0
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x000138F2 File Offset: 0x00011AF2
		public unsafe string assemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x001086C8 File Offset: 0x001068C8
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x00013911 File Offset: 0x00011B11
		public unsafe Assembly assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryAssemblyInfo.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeFieldInfoPtr_assemblyString;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Assembly_0;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr_GetAssembly_Internal_Assembly_0;
	}
}
