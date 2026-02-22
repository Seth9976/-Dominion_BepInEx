using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000045 RID: 69
	public class RegistryKeyComparer : Object
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x000334B0 File Offset: 0x000316B0
		// Note: this type is marked as 'beforefieldinit'.
		static RegistryKeyComparer()
		{
			Il2CppClassPointerStore<RegistryKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "RegistryKeyComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegistryKeyComparer>.NativeClassPtr);
			RegistryKeyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKeyComparer>.NativeClassPtr, 100663923);
			RegistryKeyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKeyComparer>.NativeClassPtr, 100663924);
			RegistryKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKeyComparer>.NativeClassPtr, 100663925);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0003351C File Offset: 0x0003171C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264896, XrefRangeEnd = 264901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKeyComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0003357C File Offset: 0x0003177C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264901, XrefRangeEnd = 264903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKeyComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000335CC File Offset: 0x000317CC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKeyComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKeyComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003C5A File Offset: 0x00001E5A
		public RegistryKeyComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
