using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000277 RID: 631
	[Serializable]
	public class SynchronizationLockException : SystemException
	{
		// Token: 0x06002B3A RID: 11066 RVA: 0x000DE410 File Offset: 0x000DC610
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationLockException()
		{
			Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SynchronizationLockException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr);
			SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr, 100670180);
			SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr, 100670181);
			SynchronizationLockException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr, 100670182);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x000DE47C File Offset: 0x000DC67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332457, XrefRangeEnd = 332462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationLockException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000DE4B8 File Offset: 0x000DC6B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 332464, RefRangeEnd = 332471, XrefRangeStart = 332462, XrefRangeEnd = 332464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationLockException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000DE504 File Offset: 0x000DC704
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 298296, RefRangeEnd = 298345, XrefRangeStart = 298296, XrefRangeEnd = 298345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationLockException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationLockException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x0000F0DB File Offset: 0x0000D2DB
		public SynchronizationLockException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
